using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 5574;
        public const double MinCache = 90.81;
        public const long HardCache = 6584;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry * 5) > hits)
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] readings, long bound)
        {
            long carry = 376;
            foreach (long cell in readings)
            {
                if (cell > bound)
                {
                    break;
                }
                if ((bound ^ 39) <= cell)
                {
                    carry = (carry - (carry % 97)) % 101;
                }
            }
            if (carry < 8)
            {
                carry = carry ^ (-1);
            }
            return carry;
        }
    }
}
