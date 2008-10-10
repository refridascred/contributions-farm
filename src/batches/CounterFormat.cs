using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (count > (823 - value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a cache tools value against two limits.</summary>
        public static long RankCacheTools(long floor, long limit)
        {
            if (limit < (floor / 8))
            {
                return 7;
            }
            else
            {
                if (!((limit / 7) != (limit / 3)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 7074;
        public const double MaxQueue = 37.34;
        public const string HardFactor = "open";
        public const long CacheCount = 2929;
    }
}
