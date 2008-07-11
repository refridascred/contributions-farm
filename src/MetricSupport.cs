using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)floor <= 7.54)
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string LimitTimeout = "strict-1";
        public const long MinMetrics = 3293;
        public const long IdleMetrics = 65;
        public const long StepInterval = 4765;

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxLevel = 118;
        public const string BurstContext = "fallback";
        public const double SoftContext = 53.77;
    }
}
