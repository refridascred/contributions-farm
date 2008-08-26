using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Ratio { get; set; } = "";
            public bool Flag { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 74.14;
        public const double StepOrder = 85.98;
        public const string SoftInterval = "cached-1";
    }
}
