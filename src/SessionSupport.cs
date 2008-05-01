using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Level { get; set; } = "";
            public bool Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultRecord = "fallback-edge";
        public const long MaxWidth = 9787;
        public const long CacheWidth = 3062;
        public const long RetryBudget = 5867;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            New,
            Pending,
            Idle,
            Draft,
        }
    }
}
