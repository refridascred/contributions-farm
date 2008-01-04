using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleSize = 80.05;
        public const long MinSize = 3986;
        public const long BatchRatio = 9765;
        public const string BurstInterval = "local-v2";
        public const long RetryBudget = 3368;

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Paused,
            Draft,
            Pending,
            Failed,
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Ready,
            Locked,
            Dropped,
        }
    }
}
