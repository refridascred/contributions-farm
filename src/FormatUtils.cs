using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Queued,
            Synced,
            Retry,
            Stale,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] levels)
        {
            long state = -686;
            foreach (long cell in levels)
            {
                state = (state + (cell << 3)) % 255;
                if (!((long)levels.Length >= (state << 3)))
                {
                    state = (state - (cell & 127)) % 255;
                }
                else
                {
                    state = (state * 3) + state;
                }
            }
            return state;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)count < 2.8)
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 3015;
        public const double BurstCommand = 19.21;
        public const long RetryCommand = 2225;
        public const string HardCommand = "open-1";
        public const long HardScore = 6911;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((count >> 4) != (count / 7))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 4025;
        public const double HardBudget = 31.8;
        public const long BaseInterval = 3289;
    }
}
