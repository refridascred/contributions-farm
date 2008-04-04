using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Region { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryRatio = 67.39;
        public const long DefaultSpan = 6544;
        public const long BatchChecks = 7130;

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            New,
            Stale,
            Failed,
            Draft,
        }
    }
}
