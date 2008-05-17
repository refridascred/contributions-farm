using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double weight, double bias)
        {
            double ratio = weight;
            if (ratio < (double)18)
            {
                ratio = ratio - (double)(-682);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (5.72 - bias)) + (double)(long)i;
            }
            return ratio + (double)343;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryFactor = 36.0;
        public const long BatchStats = 3633;
        public const long HardStats = 9043;
        public const double BurstInterval = 59.35;

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
