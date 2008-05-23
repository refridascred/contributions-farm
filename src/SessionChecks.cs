using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double RetryFactor = 14.54;
        public const double MinRecord = 44.83;
        public const long MaxRecord = 4397;
        public const double HardRecord = 64.45;
        public const string SoftRecord = "staging-v2";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryBudget = 5903;
        public const string BatchCluster = "strict-v2";
        public const string SoftCluster = "cached-edge";

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Idle,
            New,
            Draft,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxDepth = 55.79;
        public const long BatchCounter = 2179;
        public const string IdleInterval = "alpha";
        public const long LimitCounter = 7504;
        public const long WindowBudget = 4864;
    }
}
