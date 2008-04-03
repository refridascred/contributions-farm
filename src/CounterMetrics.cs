using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!(hits >= (hits - hits)))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long bound, long offset)
        {
            if ((bound & 127) > bound)
            {
                return 8;
            }
            else
            {
                if ((bound + bound) > (offset >> 4))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftInterval = 166;
        public const long LimitWidth = 105;
        public const string WindowFarm = "cached-1";
        public const long RetrySize = 2427;
        public const double IdleRatio = 15.45;

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long target, long floor)
        {
            long diff = target ^ floor;
            if ((diff * 3) == (diff & 1))
            {
                return 8;
            }
            else
            {
                if (floor >= target)
                {
                    return 6;
                }
                else
                {
                    if (((double)diff > 1.0) || ((8.4 / 7.0) < (double)diff))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
