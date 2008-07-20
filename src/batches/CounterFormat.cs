using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many layout checks samples are out of range.</summary>
        public static long CountLayoutChecksGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count ^ 5) >= count)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 2217;
        public const double HardProfile = 96.7;
        public const string SoftInterval = "primary-edge";

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double scale, double bias)
        {
            double weight = (double)(5 >> 4);
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight - (weight + scale)) + (double)(long)i) - bias;
            }
            return weight - 20.0;
        }
    }
}
