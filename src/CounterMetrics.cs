using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Closed,
            Failed,
            Active,
            Locked,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitToken = 38.53;
        public const long MinLevel = 847;
        public const long WindowScore = 3415;
        public const long BurstSize = 473;
        public const long BatchToken = 9724;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Dropped,
            Pending,
            Ready,
            Draft,
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Flag { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }
    }
}
