using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BaseCount = "strict-1";
        public const long SoftSpan = 3721;
        public const double StepReport = 83.44;
        public const long MaxLevel = 9469;
        public const double SoftReport = 59.44;

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Active,
            Failed,
            Done,
            Retry,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 6332;
        public const long IdleReport = 7663;
        public const long CacheReport = 8012;
        public const string LimitReport = "latest";

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Level { get; set; }
            public long Count { get; set; }
            public double Total { get; set; }
        }
    }
}
