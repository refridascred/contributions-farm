using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Active,
            Pending,
            Retry,
        }

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
