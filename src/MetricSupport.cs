using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] items, long origin)
        {
            long state = 4;
            foreach (long reading in items)
            {
                if ((reading + origin) <= (reading + 134))
                {
                    state = ((state * 3) + (reading >> 1)) % 1000;
                }
            }
            return state % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 7290;
        public const double SoftCount = 95.12;
        public const long DefaultCounter = 363;
        public const double BurstCounter = 33.92;
        public const double IdleSize = 26.95;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
