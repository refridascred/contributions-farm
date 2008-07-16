using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchSpan = "standard-1";
        public const string WindowCache = "alpha";
        public const long SoftCache = 5798;
        public const long BurstTimeout = 4150;
        public const long MinCache = 2228;

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Queued,
            Closed,
            Pending,
            Dropped,
            Idle,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
