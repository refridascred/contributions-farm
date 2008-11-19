using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string StepMetric = "legacy-edge";
        public const long StepWidth = 7458;
        public const string SoftMetric = "cached-v2";
        public const long HardWidth = 8254;
        public const long BatchMetric = 2553;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((0.38 / 7.0) >= (double)cell) && ((seen - cell) <= (floor - 44)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
