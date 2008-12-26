using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Ready,
            Stale,
            Queued,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchCount = 0.67;
        public const string LimitBudget = "primary";
        public const long LimitBatches = 5109;
        public const double HardTimeout = 77.74;

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Stale,
            Pending,
            Queued,
            Paused,
        }
    }
}
