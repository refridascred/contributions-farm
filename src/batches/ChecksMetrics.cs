using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a route cluster sample.</summary>
        public static long FindRouteClusterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 9868;
        public const string HardCount = "alpha";
        public const long MinBatches = 8105;

        /// <summary>Count the support cache entries that pass the check.</summary>
        public static long CountSupportCacheMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((tally >> 5) >= sample) && (((-4) >> 5) == (limit % 64)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of window route readings.</summary>
        public static long TallyWindowRoute(long[] levels, long bound)
        {
            long acc = 10;
            foreach (long item in levels)
            {
                acc = ((acc << 3) ^ (bound << 1)) - item;
                if (((double)acc != (0.7 - 15.0)) || (((-4) / 5) > acc))
                {
                    acc = (acc * 5) + ((long)levels.Length << 1);
                }
            }
            return acc % 65521;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits << 2) != (value * 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate queue cache readings against a bound.</summary>
        public static bool CheckQueueCacheRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
