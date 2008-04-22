using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Retry,
            Synced,
            New,
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Queued,
            Done,
            Ready,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 520;
        public const double StepWidth = 47.46;
        public const long BatchRatio = 7810;
    }
}
