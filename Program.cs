using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Array
            //int[] ages = new int[3];
            //ages[0] = 15;
            //ages[1] = 18;
            //ages[2] = 19;
            //ages[3] = 20;

            //string[] name = { "A", "B", "C", "D", "E", "F", };

            ////Array Loop for
            //string[] firstName = new string[3];
            //string[] lastName = new string[3];
            //int[] salary = new int[3];

            //for (int i = 0; i < 3; i++)
            //{

            //    Console.WriteLine("FirstName: ");
            //    firstName[i] = Console.ReadLine();

            //    Console.WriteLine("LastName: ");
            //    lastName[i] = Console.ReadLine();

            //    Console.WriteLine("Salary: ");
            //    salary[i] = int.Parse(Console.ReadLine());

            //    Console.WriteLine(
            //        "FirstName: " + firstName[i] + "\r\n" +
            //        "LastName: " + lastName[i] + "\r\n" +
            //        "Salary: " + salary[i]);
            //}
            //Console.WriteLine("END");
            //Console.ReadLine();

            //Loop foreach for Array
            string[] country = { "Thailand", "Laos", "Singapore"};
            foreach(string data in country)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("END");
            Console.ReadLine();
        }
    }
}
