using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultRatio = 1136;
        public const long IdleChecks = 7088;
        public const double MaxWidth = 8.22;
        public const double IdleInterval = 23.22;
        public const double MaxInterval = 40.67;

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstContext = 57.96;
        public const string LimitContext = "fallback";
        public const long BaseRatio = 7939;

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Locked,
            Active,
            Ready,
        }
    }
}
