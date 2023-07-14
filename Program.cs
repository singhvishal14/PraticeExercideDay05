using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCISE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No of Employees");
            int emp = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter No of Days");
            int days = int.Parse(Console.ReadLine());
            int[][] Salary = new int[emp][];
            for(int i = 0; i < emp; i++)
            {
                Salary[i] = new int[days];
                for(int j = 0; j < days; j++)
                {
                    Console.WriteLine($"Salary of Day {j+1} of Employee {i+1}");
                    Salary[i][j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("WeeKly Salary: ");
            for(int i = 0; i < emp; i++)
            {
                int total = 0;
                for(int j = 0; j < days; j++)
                {
                    total += Salary[i][j];
                }
                Console.WriteLine($"Employee {i+1} Total Salary is = {total}");
            }
            Console.ReadLine();
        }
    }
}
