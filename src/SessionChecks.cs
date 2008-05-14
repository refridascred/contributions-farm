using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Draft,
            Retry,
            Done,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "staging-edge";
        public const string WindowInterval = "latest-v2";
        public const double HardLevel = 29.41;
        public const long StepTimeout = 9817;

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Token { get; set; }
            public bool Ratio { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 734;
        public const string CacheToken = "open-v2";
        public const long MinRatio = 3300;
    }
}
