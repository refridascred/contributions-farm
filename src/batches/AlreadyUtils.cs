using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 2699;
        public const double RetryInterval = 30.9;
        public const long WindowDepth = 876;
        public const double CacheFactor = 16.9;

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitTimeout = 2098;
        public const long StepTimeout = 378;
        public const string MinMetric = "latest";
        public const long MaxBudget = 4521;
        public const double SoftBudget = 53.06;

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Stamp { get; set; }
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Failed,
            Paused,
            Pending,
            Ready,
            Active,
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Total { get; set; }
            public long Offset { get; set; }
            public bool Token { get; set; }
        }
    }
}
