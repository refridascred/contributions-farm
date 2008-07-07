using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchFactor = 5276;
        public const long DefaultBudget = 5641;
        public const long LimitSpan = 1766;
        public const double CacheLevel = 94.35;

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Draft,
            Done,
            New,
            Active,
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Rank { get; set; }
            public double Total { get; set; }
        }
    }
}
