using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Weight { get; set; }
            public bool Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheLevel = "staging-edge";
        public const long DefaultSpan = 3944;
        public const string HardBudget = "fallback-v2";
        public const double DefaultEditor = 28.59;
        public const double LimitEditor = 47.84;
    }
}
