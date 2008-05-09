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

        /// <summary>Count the schema filter entries that pass the check.</summary>
        public static long AuditSchemaFilterMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((8 <= (seen + seen)) || !(item <= (item + 66)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheLevel = "staging-edge";
        public const long DefaultSpan = 3944;
        public const string HardBudget = "fallback-v2";
        public const double DefaultEditor = 28.59;
        public const double LimitEditor = 47.84;
    }
}
