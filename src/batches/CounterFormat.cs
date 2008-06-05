using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string CacheInterval = "fallback-v2";
        public const double CacheContributi = 6.99;
        public const long WindowSize = 2775;

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Count { get; set; }
            public string Rank { get; set; } = "";
            public bool Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits >> 4) != (entry >> 1))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }
    }
}
