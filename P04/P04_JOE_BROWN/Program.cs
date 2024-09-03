﻿using static System.Runtime.InteropServices.JavaScript.JSType;

namespace P04_JOE_BROWN;


class Program
{

   

    static void Main(string[] args)
    {
        Console.WriteLine("P04_ex - Joe Brown\n\n");
        const double Pay = 1.0, OverTime = 1.5, DoublePay = 2.0;
        int numOfEmployees = 0;
        double totalHours = 0;
        double totalStandardPay = 0;
        double totalTimeAndHalf = 0;
        double totalDouble = 0;
        double totalEmployeePay = 0;


        do
        {
            Console.Write("Enter the number of employees to process (0 to exit): ");
            numOfEmployees = Convert.ToInt32(Console.ReadLine());
            if (numOfEmployees <= 0)
                Console.Write("ERROR: Number of employees must be greater than 0");
        } while (numOfEmployees < 0);
        if (numOfEmployees == 0) return;
        



        int employeeNumber = 1;


        while (employeeNumber <= numOfEmployees)
        {
            Console.WriteLine($"\t\t\tEmployee: {employeeNumber}");
            double hourlyRate;
            do
            {
                //get rate (do-while
                Console.Write("Provide the pay rate for each employee between $5.25 and $30.00 ");

                hourlyRate = Convert.ToDouble(Console.ReadLine());
                if (hourlyRate < 5.25 || hourlyRate > 30.00)
                    Console.Write("Pay must be between $5.25 and $30.00");
            } while (hourlyRate < 5.25 || hourlyRate > 30.00);

            int w1, w2, w3, w4;
            bool qtyError;
            do
            {
                qtyError = false;
                Console.Write("Enter the hours worked for each week of the month between 0 and 60 including 0 and 60, each week seperated by a space: ");
                string[] hoursWorked = Console.ReadLine().Split(' ');
                
                w1 = int.Parse(hoursWorked[0]);
                w2 = int.Parse(hoursWorked[1]);
                w3 = int.Parse(hoursWorked[2]);
                w4 = int.Parse(hoursWorked[3]);

                if (w1 < 0 || w2 < 0 || w3 < 0 || w4 < 0)
                {
                    Console.WriteLine("error");
                    qtyError = true;
                }
                if (w1 > 60 || w2 > 60 || w3 > 60 || w4 > 60)
                {
                    Console.WriteLine("error");
                    qtyError = true;
                }
            } while (qtyError);


            double w1Pay1;
            double w1Pay2;
            double w1Pay3;


            if (w1 <= 40)
            {

                w1Pay1 = w1 * hourlyRate;
                w1Pay2 = 0;
                w1Pay3 = 0;

            }
            else
            {
                if (w1 <= 50)
                {
                    w1Pay1 = 40 * hourlyRate;
                    w1Pay2 = (w1 - 40) * hourlyRate * OverTime;
                    w1Pay3 = 0;

                }
                else
                {
                    w1Pay1 = 40 * hourlyRate;
                    w1Pay2 = 10 * hourlyRate * OverTime;
                    w1Pay3 = (w1 - 50) * hourlyRate * DoublePay;
                }

            }
            double w2Pay1;
            double w2Pay2;
            double w2Pay3;


            if (w2 <= 40)
            {

                w2Pay1 = w2 * hourlyRate;
                w2Pay2 = 0;
                w2Pay3 = 0;

            }
            else
            {
                if (w2 <= 50)
                {
                    w2Pay1 = 40 * hourlyRate;
                    w2Pay2 = (w2 - 40) * hourlyRate * OverTime;
                    w2Pay3 = 0;

                }
                else
                {
                    w2Pay1 = 40 * hourlyRate;
                    w2Pay2 = 10 * hourlyRate * OverTime;
                    w2Pay3 = (w2 - 50) * hourlyRate * DoublePay;
                }

            }
            double w3Pay1;
            double w3Pay2;
            double w3Pay3;


            if (w3 <= 40)
            {

                w3Pay1 = w3 * hourlyRate;
                w3Pay2 = 0;
                w3Pay3 = 0;

            }
            else
            {
                if (w3 <= 50)
                {
                    w3Pay1 = 40 * hourlyRate;
                    w3Pay2 = (w3 - 40) * hourlyRate * OverTime;
                    w3Pay3 = 0;

                }
                else
                {
                    w3Pay1 = 40 * hourlyRate;
                    w3Pay2 = 10 * hourlyRate * OverTime;
                    w3Pay3 = (w3 - 50) * hourlyRate * DoublePay;
                }

            }
            double w4Pay1;
            double w4Pay2;
            double w4Pay3;


            if (w4 <= 40)
            {

                w4Pay1 = w4 * hourlyRate;
                w4Pay2 = 0;
                w4Pay3 = 0;

            }
            else
            {
                if (w4 <= 50)
                {
                    w4Pay1 = 40 * hourlyRate;
                    w4Pay2 = (w4 - 40) * hourlyRate * OverTime;
                    w4Pay3 = 0;

                }
                else
                {
                    w4Pay1 = 40 * hourlyRate;
                    w4Pay2 = 10 * hourlyRate * OverTime;
                    w4Pay3 = (w4 - 50) * hourlyRate * DoublePay;
                }

            }


            Console.WriteLine("\nW1 \tRate \tHours \t1.0 \t1.5 \t2.0 \tTotal ");

            // employeeNumber++;
            Console.WriteLine();

            double w1Gross;
            double w2Gross;
            double w3Gross;
            double w4Gross;

            w1Gross = w1Pay1 + w1Pay2 + w1Pay3;
            w2Gross = w2Pay1 + w2Pay2 + w2Pay3;
            w3Gross = w3Pay1 + w3Pay2 + w3Pay3;
            w4Gross = w4Pay1 + w4Pay2 + w4Pay3;

            double monthlyGross;
            monthlyGross = w1Gross + w2Gross + w3Gross + w4Gross;

            double monthlyHours;
            monthlyHours = w1 + w2 + w3 + w4;
            totalHours += monthlyHours;
           
            double standard;
            standard = w1Pay1 + w2Pay1 + w3Pay1 + w4Pay1;
               
            totalStandardPay += standard;

            double sumOfTimeHalf;
            sumOfTimeHalf = w1Pay2 + w2Pay2 + w3Pay2 + w4Pay2;
             
            totalTimeAndHalf += sumOfTimeHalf;

            double sumOfDouble;
            sumOfDouble = w1Pay3 + w2Pay3 + w3Pay3 + w4Pay3;
              
            totalDouble += sumOfDouble;

            double sumOfGross;
            sumOfGross = w1Gross + w2Gross + w3Gross + w4Gross;
            totalEmployeePay += sumOfGross;


            Console.Write($"WK1\t{hourlyRate}\t{w1}\t{w1Pay1:N2}\t{w1Pay2:N2}\t{w1Pay3:N2}\t{w1Gross:N2}\n");
            Console.Write($"WK2\t{hourlyRate}\t{w2}\t{w2Pay1:N2}\t{w2Pay2:N2}\t{w2Pay3:N2}\t{w2Gross:N2}\n");
            Console.Write($"WK3\t{hourlyRate}\t{w3}\t{w3Pay1:N2}\t{w3Pay2:N2}\t{w3Pay3:N2}\t{w3Gross:N2}\n");
            Console.Write($"WK4\t{hourlyRate}\t{w4}\t{w4Pay1:N2}\t{w4Pay2:N2}\t{w4Pay3:N2}\t{w4Gross:N2}\n");
            Console.WriteLine();
            Console.Write($"Employee Totals: {w1 + w2 + w3 + w4}\t{w1Pay1 + w2Pay1 + w3Pay1 + w4Pay1}\t{w1Pay2 + w2Pay2 + w3Pay2 + w4Pay2}\t{w1Pay3 + w2Pay3 + w3Pay3 + w4Pay3}\t{monthlyGross:N2}\n");
            Console.WriteLine();
            Console.WriteLine("Press Enter to process the next employee or the report totals: ");
            Console.ReadLine();



            employeeNumber++;
            
        }
        double avgGross;
        avgGross = totalEmployeePay / numOfEmployees;
        Console.WriteLine();
        Console.WriteLine("Report Totals\n");
        Console.WriteLine($"Hours\t1.0\t1.5\t2.0\tTotal\n");
        Console.WriteLine($"{totalHours}\t{totalStandardPay}\t{totalTimeAndHalf:N2}\t{totalDouble:N2}\t{totalEmployeePay:N2}");
        


        Console.WriteLine($"Number of Employees:\t\t{numOfEmployees}\t\tAverage Gross: {avgGross:N2}\t");
        Console.WriteLine();
        

        }
    }











    

