using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string SoftRatio = "fallback-v2";
        public const long LimitWidth = 6989;
        public const double MaxGraph = 0.61;
        public const long BatchGraph = 2630;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Stale,
            Ready,
            Queued,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Pending,
            Queued,
            Active,
        }
    }
}
