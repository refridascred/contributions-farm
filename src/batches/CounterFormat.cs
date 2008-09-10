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

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxFactor = 4109;
        public const long BaseCache = 9446;
        public const long StepSize = 6185;
        public const double IdleCount = 9.9;
        public const long IdleCache = 2103;

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
