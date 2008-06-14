using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double BaseTimeout = 31.61;
        public const double BatchSupport = 30.37;
        public const long BaseLevel = 3356;

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Retry,
            Failed,
            Stale,
            Idle,
            Active,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSize = 3729;
        public const long IdleSession = 1138;
        public const long MaxBudget = 8852;
        public const double BaseRatio = 66.07;
    }
}
