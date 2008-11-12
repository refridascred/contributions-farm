using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Retry,
            Dropped,
            Queued,
            New,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleWidth = "local-1";
        public const long CacheLevel = 4629;
        public const double CacheCommand = 45.18;

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
