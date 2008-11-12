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

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
