using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Active,
            New,
            Ready,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 5810;
        public const long CacheSize = 1898;
        public const string LimitDepth = "fallback-1";
        public const long SoftContributi = 926;
        public const string MaxContributi = "cached-1";

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
