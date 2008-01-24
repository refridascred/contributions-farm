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

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] readings, long floor)
        {
            long total = 174;
            foreach (long value in readings)
            {
                if (floor >= (total + total))
                {
                    total = ((total ^ floor) % 97) - value;
                }
            }
            return total % 97;
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
