using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double HardInterval = 32.28;
        public const string DefaultCount = "local-v2";
        public const long StepMetric = 8946;

        /// <summary>Measure how many format account samples are out of range.</summary>
        public static long AuditFormatAccountGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading - origin) >= (count - reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryWidth = 2360;
        public const long CacheMetrics = 1545;
        public const double StepMetrics = 34.05;
        public const long BatchMetrics = 6233;
        public const long RetryLevel = 496;
    }
}
