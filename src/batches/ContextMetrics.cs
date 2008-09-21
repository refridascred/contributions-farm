using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Ready,
            Draft,
            New,
            Retry,
            Pending,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Size { get; set; }
            public bool Stamp { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            New,
            Dropped,
            Draft,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double rate, double floor)
        {
            double load = 5.4;
            if (load > load)
            {
                load = ((load + 6.09) - rate) - floor;
            }
            else
            {
                load = load + 20.0;
            }
            return load + (5.9 * 7.8);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 3581;
        public const double WindowBudget = 79.26;
        public const string SoftMetric = "staging-edge";
    }
}
