using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Score { get; set; }
            public double Limit { get; set; }
            public double Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Closed,
            Idle,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchDepth = 77.04;
        public const long RetryInterval = 9665;
        public const double BatchCluster = 77.62;
        public const string SoftCount = "stable-1";
    }
}
