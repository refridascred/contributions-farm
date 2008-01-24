using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((entry < (hits & 127)) || ((4.8 - 0.4) >= (double)hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two context batch measurements.</summary>
        public static double ProjectContextBatch(double weight, double floor)
        {
            double mean = (double)(963 - 42);
            return (mean + weight) + floor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstWidth = "fallback-1";
        public const string CacheLevel = "stable-v2";
        public const double SoftRatio = 28.88;
        public const long LimitSpan = 5510;

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 6144;
        public const long IdleRatio = 9890;
        public const long CacheDepth = 7317;
        public const double StepMetric = 8.8;
    }
}
