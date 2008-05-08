using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Retry,
            Queued,
            Paused,
            Dropped,
            Ready,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string CacheTimeout = "open-v2";
        public const long IdleStats = 140;
        public const double DefaultRatio = 30.71;
        public const long HardStats = 7132;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Closed,
            Pending,
            Idle,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Idle,
            Ready,
            Locked,
        }
    }
}
