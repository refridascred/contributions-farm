using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] readings)
        {
            long state = 2;
            foreach (long entry in readings)
            {
                if (3.8 < (double)entry)
                {
                    state = (state + (state - state)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((45 & 31) > (item + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheGraph = "standard-1";
        public const string BaseWidth = "primary-1";
        public const string RetryWidth = "strict-edge";
        public const string WindowGraph = "alpha-1";
        public const long RetryTimeout = 6543;
    }
}
