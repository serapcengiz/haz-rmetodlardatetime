using System;
namespace hazırmetodlardatetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);//günün tarihini getirir
            Console.WriteLine(DateTime.Now.Date);//
            Console.WriteLine(DateTime.Now.Day);//günün tarihini getirir
            Console.WriteLine(DateTime.Now.Month);//günün tarihini getirir
            Console.WriteLine(DateTime.Now.Year);//günün tarihini getirir
            Console.WriteLine(DateTime.Now.Hour);//günün tarihini getirir
            Console.WriteLine(DateTime.Now.Minute);//günün tarihini getirir
            Console.WriteLine(DateTime.Now.Second);//günün tarihini getirir

            Console.WriteLine(DateTime.Now.DayOfWeek);//günün tarihini getirir
            Console.WriteLine(DateTime.Now.DayOfYear);//günün tarihini getirir
            
            Console.WriteLine(DateTime.Now.ToLongDateString());//günün tarihini getirir
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            
            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));


            //DateTimeFormat
            Console.WriteLine(DateTime.Now.ToString("dd"));//24
            Console.WriteLine(DateTime.Now.ToString("ddd"));//Sat
            Console.WriteLine(DateTime.Now.ToString("dddd"));//Saturday

            Console.WriteLine(DateTime.Now.ToString("MM"));//04
            Console.WriteLine(DateTime.Now.ToString("MMM"));//apr
            Console.WriteLine(DateTime.Now.ToString("MMMM"));//april

            Console.WriteLine(DateTime.Now.ToString("yy"));//21
            Console.WriteLine(DateTime.Now.ToString("yyyy"));//2021


            //Math Kütüphaneleri
            Console.WriteLine(Math.Abs(-25));//25
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));

            Console.WriteLine(Math.Ceiling(22.3));//23
            Console.WriteLine(Math.Round(22.3));//22
            Console.WriteLine(Math.Round(22.7));//23
            Console.WriteLine(Math.Floor(22.7));//22

            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6));

            Console.WriteLine(Math.Pow(2,6));
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Log(9));
            Console.WriteLine(Math.Exp(3));
            Console.WriteLine(Math.Log10(10));
            
        }   

    }
}