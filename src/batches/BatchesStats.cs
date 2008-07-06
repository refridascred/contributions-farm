using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Stale,
            Idle,
            Done,
            New,
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            Done,
            Stale,
            Ready,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 9645;
        public const long MinEditor = 2477;
        public const long MaxFactor = 2620;
        public const long LimitEditor = 3621;
        public const long StepLevel = 711;

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinSize = 136;
        public const long CacheMetric = 6618;
        public const string LimitMetric = "cached-edge";
        public const long HardMetric = 5837;
    }
}
