using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Closed,
            Stale,
            Pending,
            Dropped,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Dropped,
            Failed,
            Paused,
            Ready,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheRatio = 9646;
        public const long MaxScore = 9583;
        public const long MinSize = 6863;
        public const long BurstFactor = 1319;
    }
}
