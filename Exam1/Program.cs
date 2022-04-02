using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{

    public class InheritanceObjects
    {
        public class Person
        {
            protected string Name { get; set; }

            public Person(string name)
            {
                Name = name;
            }
            public override string ToString()
            {
                return "Hello! My name is " + Name;
            }
        }

        public class Teacher : Person
        {
            public Teacher(string name) : base(name)
            {
                Name = name;
            }

            public void Explain()
            {
                Console.WriteLine("Explain");
            }
        }

        public class Student : Person
        {
            public Student(string name) : base(name)
            {
                Name = name;
            }

            public void Study()
            {
                Console.WriteLine("Study");
            }
        }
            public static void Main(string[] args)
            {
                int total = 3;
                Person[] persons = new Person[total];

                for (int i = 0; i < total; i++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine("Enter Teacher Name:");
                        persons[i] = new Teacher(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Enter Student Name:");
                        persons[i] = new Student(Console.ReadLine());
                    }
                }

                for (int i = 0; i < total; i++)
                {
                    if (i == 0)
                    {

                       Console.WriteLine(persons[i].ToString());
                        ((Teacher)persons[i]).Explain();

                    }
                    else
                    {
                        Console.WriteLine(persons[i].ToString());
                        ((Student)persons[i]).Study();
                    }
                }
            Console.ReadKey();
            }
    }
}
