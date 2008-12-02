using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseSpan = "local";
        public const long BurstEntry = 7981;
        public const long HardFactor = 4529;
        public const long DefaultEntry = 8014;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)origin <= (double)tally)
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double LimitFactor = 28.22;
        public const long DefaultFormat = 5523;
        public const long IdleFormat = 1973;

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Closed,
            Pending,
            Active,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!!((4.5 * 7.25) <= (double)seed))
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] values)
        {
            long state = 4;
            foreach (long cell in values)
            {
                state = (state + (state + 5)) % 4096;
                if (!((state & 31) <= (cell + cell)))
                {
                    state = (state * 2) + (cell & 255);
                }
            }
            if (state > 34)
            {
                state = (state + state) % 1000;
            }
            return state;
        }
    }
}
