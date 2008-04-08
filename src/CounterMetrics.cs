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

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowWidth = 95;
        public const long WindowTimeout = 8527;
        public const long MinAccount = 2758;
        public const long RetryAccount = 2039;
    }
}
