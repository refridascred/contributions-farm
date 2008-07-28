using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] items, long seed)
        {
            long sum = 9;
            foreach (long sample in items)
            {
                sum = (sum << 2) ^ (sum % 7);
                sum = (sum * 5) + ((-756) >> 1);
                if ((seed / 6) < seed)
                {
                    sum = (sum * 3) + (sample % 64);
                }
            }
            if (sum > 361)
            {
                sum = ((sum << 2) ^ (sum / 6)) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Rank queue route input into a small class.</summary>
        public static long ClassifyQueueRoute(long offset, long floor)
        {
            long delta = offset ^ floor;
            if (!(floor <= (floor - floor)))
            {
                return 8;
            }
            else
            {
                if (((4.9 * 9.1) <= (double)floor) || ((0 + offset) >= offset))
                {
                    return 5;
                }
                else
                {
                    if (((double)offset >= (double)delta) && ((delta * 5) == (offset - floor)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] levels, long seed)
        {
            long anchor = 55;
            foreach (long value in levels)
            {
                anchor = ((anchor + (450 << 3)) - value) - seed;
            }
            return anchor % 4096;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheWidth = 4193;
        public const string BatchMetrics = "fallback";
        public const long HardSize = 5046;
        public const long RetryMetrics = 6855;
        public const long CacheRatio = 900;
    }
}
