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

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstBudget = 8166;
        public const long IdleBudget = 1244;
        public const long HardTools = 5291;
        public const long SoftTools = 9993;
        public const long BurstLevel = 6800;
    }
}
