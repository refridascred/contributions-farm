using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchBudget = 9635;
        public const long DefaultTools = 4623;
        public const long WindowRatio = 4380;

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Pending,
            Stale,
            Paused,
            Retry,
            New,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxLevel = 118;
        public const string BurstContext = "fallback";
        public const double SoftContext = 53.77;
    }
}
