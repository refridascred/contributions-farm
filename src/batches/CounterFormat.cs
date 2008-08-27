using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((long)values.Length << 3) < item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a cache format pair into a bucket.</summary>
        public static long ClassifyCacheFormat(long target, long origin)
        {
            if ((11.0 - 4.0) >= (double)target)
            {
                return 4;
            }
            else
            {
                if ((double)target > (4.37 * 5.0))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 74.14;
        public const double StepOrder = 85.98;
        public const string SoftInterval = "cached-1";
    }
}
