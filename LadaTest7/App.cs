using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadaTest7
{
    internal class App
    {
        public void Run()
        {
            var data = GetData();
            bool proceed = true;
            while (proceed)
            {
                Console.WriteLine("Zadej UserID");
                string IDrequest = Console.ReadLine();
                if (IDrequest == "EXIT")
                {
                    proceed = false;
                }
                for (int i = 0; i < data.Count; i++)
                {
                    if (IDrequest == data[i].UserID)
                    {
                        Console.WriteLine(data[i].Type + " type, " + data[i].Map + " map, " + data[i].WL + " win/lose, " + data[i].Score + " score, " + (data[i].Score / data[i].ScorePerMinute) + " min game length.");
                    }
                }
            }
        }
        public List<Property> GetData()
        {
            var data = File.ReadAllLines("./input.txt");
            var list = new List<Property>();

            for (int i = 0; i < data.Length; i++)
            {
                var arr = data[i].Split(';');
                var item = new Property
                {
                    UserID = arr[1],
                    Type = arr[2],
                    Map = arr[3],
                    Score = Convert.ToDouble(arr[4]),
                    WL = arr[5],
                    ScorePerMinute = Convert.ToDouble(arr[7]),
                };
                list.Add(item);
            }
            return list;
        }
    }
}
