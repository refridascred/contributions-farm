using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowInterval = 37.26;
        public const long BatchInterval = 3772;
        public const string BurstGraph = "legacy";

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Dropped,
            New,
            Failed,
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Retry,
            Ready,
            Active,
            Closed,
        }
    }
}
