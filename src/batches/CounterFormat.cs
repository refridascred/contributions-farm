using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 > (offset / 3.0))
            {
                rate2 = rate2 + (double)787;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 + offset) + (double)(long)i;
            }
            return rate2 + rate;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Count { get; set; }
            public double Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double rate, double floor)
        {
            double weight = (double)(841 - 311);
            if (weight > weight)
            {
                weight = (weight + (rate * 8.69)) - floor;
            }
            else
            {
                weight = weight - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight - 5.0;
        }
    }
}
