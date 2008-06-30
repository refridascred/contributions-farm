using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Retry,
            New,
            Locked,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 8692;
        public const double BaseMetrics = 45.98;
        public const long LimitMetrics = 5213;
        public const long BatchMetrics = 9372;
        public const double IdleMetrics = 84.63;

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Pending,
            Stale,
            Retry,
            Locked,
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
