using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Done,
            Idle,
            Queued,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryDepth = 3118;
        public const long StepCount = 788;
        public const long BaseBudget = 2627;

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultTimeout = 9030;
        public const long MaxSize = 6500;
        public const double BurstCount = 3.02;
        public const long DefaultSize = 1354;
        public const long BaseFactor = 276;
    }
}
