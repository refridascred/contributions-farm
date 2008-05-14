using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Failed,
            Ready,
            Done,
            New,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleTimeout = 5328;
        public const long SoftCount = 1597;
        public const string BaseSize = "local";
        public const long BurstBudget = 3959;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Locked,
            Closed,
            Dropped,
        }
    }
}
