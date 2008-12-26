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

        /// <summary>Define window limits and defaults.</summary>
        public const string HardSpan = "strict-1";
        public const string BurstFactor = "alpha";
        public const long MinWindow = 4054;
        public const long CacheLevel = 5319;

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
