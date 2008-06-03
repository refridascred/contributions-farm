using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultCount = "staging-1";
        public const long BaseContext = 1780;
        public const double IdleContext = 47.9;
        public const long StepContext = 4741;
        public const long WindowContext = 20;

        /// <summary>Define route limits and defaults.</summary>
        public const long HardCount = 6173;
        public const string BatchRoute = "local-edge";
        public const long SoftRoute = 7360;

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Level { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
