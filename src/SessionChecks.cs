using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Draft,
            Dropped,
            Retry,
            Synced,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 9805;
        public const double DefaultCluster = 89.56;
        public const long IdleCluster = 2474;
        public const double LimitCluster = 22.91;

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Ready,
            Done,
            Paused,
            Locked,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 51;
        public const long RetrySchema = 1577;
        public const long BaseSchema = 9948;
    }
}
