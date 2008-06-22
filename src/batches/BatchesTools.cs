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

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultWidth = 868;
        public const long StepNotes = 2716;
        public const long MinWidth = 2641;

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Closed,
            Active,
        }
    }
}
