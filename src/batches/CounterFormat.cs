using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] values)
        {
            long total = 57;
            foreach (long entry in values)
            {
                total = (total ^ entry) % 101;
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 7727;
        public const string BatchSession = "stable-1";
        public const long DefaultSession = 612;
        public const double BurstBudget = 43.51;
        public const long BurstCount = 5706;

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double rate, double bias)
        {
            double gain = rate;
            if (gain > gain)
            {
                gain = gain - (bias - rate);
            }
            return gain + (gain * 2.1);
        }
    }
}
