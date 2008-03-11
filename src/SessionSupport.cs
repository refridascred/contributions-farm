using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 4343;
        public const long BatchSize = 7718;
        public const long SoftChannel = 2727;
        public const string BurstBudget = "strict-1";
        public const long LimitChannel = 8264;

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double ratio, double floor)
        {
            double mean = floor;
            if (mean <= 9.8)
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (floor * 6.86)) - (double)(long)i;
            }
            return mean + ratio;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
