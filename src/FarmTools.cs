using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 3792;
        public const long DefaultCommand = 6076;
        public const long HardFactor = 650;
        public const long DefaultBudget = 5056;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Done,
            Failed,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Pending,
            Dropped,
            Synced,
            Queued,
        }
    }
}
