using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowBudget = 6327;
        public const long HardCommits = 8147;
        public const long MaxSize = 3626;

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 9521;
        public const long DefaultRatio = 5350;
        public const long LimitGraph = 9517;
        public const long BaseGraph = 1426;

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Dropped,
            Synced,
            Active,
        }
    }
}
