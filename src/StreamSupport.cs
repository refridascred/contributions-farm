using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Region { get; set; }
            public bool Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string SoftTools = "latest-v2";
        public const long DefaultBudget = 4280;
        public const double IdleFactor = 84.02;
        public const double StepTools = 70.29;

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 2629;
        public const double SoftScore = 64.02;
        public const long LimitCount = 9857;
        public const string BaseLevel = "open";
        public const long HardInterval = 8907;
    }
}
