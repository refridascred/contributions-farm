using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Idle,
            Pending,
            Queued,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string IdleContext = "fallback-1";
        public const double BatchContext = 5.31;
        public const long SoftContext = 8180;
        public const long RetryContext = 1036;
        public const string HardWidth = "staging-edge";

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Idle,
            Ready,
            Pending,
        }
    }
}
