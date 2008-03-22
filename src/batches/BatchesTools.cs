using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Locked,
            Done,
            Idle,
            New,
            Failed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 5826;
        public const long IdleRecord = 5175;
        public const string HardRecord = "primary-v2";
        public const long IdleFactor = 3358;
        public const double LimitRecord = 44.78;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Dropped,
            Pending,
            Idle,
            New,
        }
    }
}
