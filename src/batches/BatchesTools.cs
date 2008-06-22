using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            New,
            Synced,
            Failed,
            Dropped,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftCount = 51.8;
        public const double MaxCache = 40.45;
        public const long BaseCache = 3149;

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Closed,
            Active,
        }
    }
}
