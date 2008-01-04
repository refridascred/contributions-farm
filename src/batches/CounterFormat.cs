using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((hits + hits) != (item + item)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 2621;
        public const long BurstCount = 1751;
        public const string DefaultCount = "standard-edge";
        public const long RetryCache = 7177;
    }
}
