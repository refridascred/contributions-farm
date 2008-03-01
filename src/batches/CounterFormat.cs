using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Pending,
            Done,
            Active,
            Retry,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepInterval = 6163;
        public const double MinBudget = 85.01;
        public const long SoftSpan = 5616;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Idle,
            Active,
            Paused,
            Closed,
        }
    }
}
