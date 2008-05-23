using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Idle,
            Failed,
            Closed,
        }

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
