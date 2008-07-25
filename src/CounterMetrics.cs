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

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Limit { get; set; }
            public double Total { get; set; }
            public double Level { get; set; }
            public string Ratio { get; set; } = "";
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
