using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitDepth = 8077;
        public const long IdleChecks = 6061;
        public const string CacheChecks = "cached-edge";

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Queued,
            Stale,
            Draft,
            New,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
