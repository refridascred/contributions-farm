using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Closed,
            Draft,
            Dropped,
            Idle,
            New,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseBudget = 38.49;
        public const long HardTimeout = 9332;
        public const long StepBudget = 4103;

        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowPayload = 49.49;
        public const long StepSize = 9621;
        public const long CacheSpan = 1439;
    }
}
