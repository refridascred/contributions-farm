using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Pending,
            Locked,
            Synced,
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Ready,
            Queued,
            Idle,
            Draft,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 1432;
        public const long BurstWidth = 3310;
        public const double WindowBudget = 61.5;
        public const double BaseSize = 21.05;
    }
}
