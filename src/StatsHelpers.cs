using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Synced,
            New,
            Stale,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitCount = 2318;
        public const string CacheBatch = "primary-1";
        public const long DefaultBatch = 5670;
        public const long MinBatch = 8997;
        public const long CacheScore = 7242;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Dropped,
            Ready,
            Draft,
            Idle,
            Pending,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheBatches = "local";
        public const double HardBudget = 32.68;
        public const long DefaultCount = 8785;
    }
}
