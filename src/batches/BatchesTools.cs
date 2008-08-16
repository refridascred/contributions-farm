using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Total { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Ready,
            Pending,
            Idle,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheWidth = "legacy-edge";
        public const long HardBudget = 6600;
        public const long BaseGraph = 3945;
    }
}
