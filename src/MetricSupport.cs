using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Paused,
            Retry,
            Done,
            Pending,
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Ready,
            Draft,
            Queued,
            Active,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstDepth = 7236;
        public const long MaxSize = 181;
        public const double WindowSpan = 21.19;
    }
}
