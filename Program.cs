using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace body_mass_index
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Body Mass Index (BMI) Calculation");


            Console.WriteLine("Enter a weight (kg):");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a height (m):");
            double height = Convert.ToDouble(Console.ReadLine());


            double bmi = weight / (height * height);
            string weightStatus;

            if (bmi < 18.5)
            {
                weightStatus = "Underweight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                weightStatus = "Healthy Weight";
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                weightStatus = "Overweight";
            }
            else
            {
                weightStatus = "Obesity";
            }

            Console.WriteLine($"BMI: {bmi:0.#}");
            Console.WriteLine($"Weight status:{weightStatus}");
            Console.ReadLine();



        }
    }
}
