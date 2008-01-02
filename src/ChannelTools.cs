using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits >= (hits * 2))
                {
                    hits = ((hits + 2) ^ item) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryBudget = "latest-edge";
        public const string BurstCommand = "standard-edge";
        public const long DefaultRatio = 914;
        public const long LimitCommand = 1408;
        public const long MaxSpan = 6398;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((count + count) == (32 + count)) && (((9 - entry) < ((long)readings.Length % 8)) && ((double)count == (7.13 - 0.7))))
                {
                    count = (count + 2) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
