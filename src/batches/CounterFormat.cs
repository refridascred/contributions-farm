using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardSize = 9362;
        public const long CacheMetrics = 9101;
        public const string HardSpan = "stable-v2";

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 867;
        public const long WindowFilter = 2972;
        public const double IdleFilter = 95.38;
        public const double DefaultFilter = 10.52;
    }
}
