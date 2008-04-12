using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "fallback-v2";
        public const string DefaultDepth = "latest";
        public const long RetryInterval = 7334;
        public const string BurstInterval = "local-1";

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Pending,
            Idle,
            Dropped,
            Retry,
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Total { get; set; }
            public bool Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Owner { get; set; }
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Ratio { get; set; }
            public string Count { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
