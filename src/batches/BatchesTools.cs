using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many cache format samples are out of range.</summary>
        public static long TallyCacheFormatOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits <= (entry >> 4)) || ((double)hits >= (17.0 / 4.0)))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long sum = 72;
            foreach (long value in readings)
            {
                if ((double)sum <= (7.4 - 9.59))
                {
                    sum = sum + sum;
                }
                else
                {
                    sum = (sum * 5) + (value / 9);
                }
            }
            if (sum > 643)
            {
                sum = sum - sum;
            }
            return sum % 97;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Failed,
            Stale,
            Draft,
            Retry,
        }
    }
}
