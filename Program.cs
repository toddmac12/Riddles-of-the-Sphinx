using System;
using System.Collections.Generic;
using Sphinx.Models;

namespace Sphinx
{
  public class Program
  {
    public static Riddle riddle1 = new Riddle("The bigger I get, the less there is. What am I?", "hole");
    public static Riddle riddle2 = new Riddle("I am always running, never walking. Sometimes babbling, never talking. What am I?", "river");
    public static Riddle riddle3 = new Riddle("What goes on four legs in the morning, two in the afternoon and three in the evening?", "man");
    public static List<Riddle> Riddles = new List<Riddle>() { riddle1, riddle2, riddle3 };

    public static int RandomNumber()
    {
      Random _random = new Random();
      return _random.Next(0, Riddles.Count);
    }
    
    public static void RandomRiddle()
    {
      int riddleNum = RandomNumber();
      Console.WriteLine(Riddles[riddleNum].Question);
      string playerAnswer = Console.ReadLine();
      if (playerAnswer == Riddles[riddleNum].Answer)
      {
        Console.WriteLine("Correct!");
        Riddles.RemoveAt(riddleNum);
      }
      else
      {
        Console.WriteLine("Wrong! The sphinx greedily devours you!");
        Main();
      }
    }

    public static void Main()
    {
      Console.WriteLine("RIDDLE OF THE SPHINX");
      Console.WriteLine("--------------------");
      Console.WriteLine("ANSWER THE SPHINX'S RIDDLES OR BE DEVOURED");
      Console.WriteLine("");
      RandomRiddle();
      RandomRiddle();
      RandomRiddle();
      Console.WriteLine("Congratulations! You have impressed the Sphinx and earned the right to not be killed and eaten.");
    }
  }  
}