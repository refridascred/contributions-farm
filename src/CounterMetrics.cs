using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Closed,
            Idle,
            Queued,
            Paused,
            Pending,
        }

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
