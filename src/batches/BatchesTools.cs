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

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstCluster = 32.17;
        public const double BaseCluster = 42.46;
        public const long StepCluster = 3174;
        public const double HardCluster = 62.43;
    }
}
