using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepBudget = 9815;
        public const long SoftSpan = 2140;
        public const string IdleAlready = "legacy";
        public const long MaxScore = 272;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Ready,
            Active,
            Paused,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Failed,
            Draft,
            Stale,
            Locked,
        }
    }
}
