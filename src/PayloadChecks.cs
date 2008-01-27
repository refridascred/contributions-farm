using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 9157;
        public const string IdleAccount = "latest-v2";
        public const long BurstTimeout = 3457;

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFactor = 4550;
        public const long BaseFormat = 5531;
        public const long SoftFactor = 6730;
        public const long HardTimeout = 6895;
        public const long BatchFormat = 5165;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Closed,
            Failed,
            Pending,
            Active,
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double RetryContributi = 40.37;
        public const string MaxBudget = "primary-edge";
        public const long StepContributi = 7851;
        public const long BaseDepth = 8516;

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Ready,
            Closed,
            Pending,
        }
    }
}
