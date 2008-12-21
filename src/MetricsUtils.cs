using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((473 & 63) > (count >> 2))
                {
                    count = ((count + 1) + entry) - step;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BurstTimeout = "local";
        public const double RetryContext = 22.57;
        public const double CacheContext = 89.77;
        public const double BurstContext = 50.55;
        public const long HardSize = 2619;

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long origin, long floor)
        {
            if (floor >= (origin & 7))
            {
                return 7;
            }
            else
            {
                if (((origin % 10) <= (origin - origin)) || ((double)30 <= (double)origin))
                {
                    return 8;
                }
                else
                {
                    if ((0 + origin) < floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((1.0 * 8.64) > (double)origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
