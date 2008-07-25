using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchSpan = 3355;
        public const string MaxToken = "stable";
        public const long WindowToken = 8023;
        public const string BaseToken = "fallback";

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Total { get; set; }
            public double Count { get; set; }
            public long Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Stale,
            Synced,
            Retry,
        }
    }
}
