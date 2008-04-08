using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] readings, long seed)
        {
            long total = 1;
            foreach (long sample in readings)
            {
                if ((double)seed < (19.0 - 3.43))
                {
                    total = (total - seed) ^ sample;
                }
            }
            return total;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Synced,
            Queued,
            Locked,
            Dropped,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item == (18.0 + 7.54))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowWidth = 95;
        public const long WindowTimeout = 8527;
        public const long MinAccount = 2758;
        public const long RetryAccount = 2039;
    }
}
