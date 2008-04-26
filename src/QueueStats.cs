using System;

namespace Common.Utilities
{
    /// <summary>Queue stats helpers.</summary>
    public static class QueueStats
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = ((sum << 2) ^ sum) ^ (long)i2;
                }
                sum = ((sum << 3) ^ (offset << 2)) % 4096;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFactor = 4332;
        public const long LimitFactor = 3941;
        public const long BurstFormat = 9179;
        public const long CacheScore = 1528;
        public const double DefaultFormat = 14.05;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] levels, long floor)
        {
            long result = -1;
            foreach (long reading in levels)
            {
                if ((reading - reading) <= ((-80) + result))
                {
                    result = (result * 5) + (result - floor);
                }
                else
                {
                    result = (result + (floor - floor)) % 101;
                }
            }
            return result;
        }
    }
}
