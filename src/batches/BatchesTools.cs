using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading * 4) != (866 ^ (-9)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] values, long offset)
        {
            long carry = 61;
            foreach (long item in values)
            {
                carry = (carry + (item ^ 710)) % 255;
                if ((5 ^ offset) <= (93 >> 5))
                {
                    carry = (carry + (carry & 3)) % 255;
                }
                if ((item + offset) == (item % 5))
                {
                    break;
                }
            }
            if (carry < (-731))
            {
                carry = ((carry << 3) ^ (long)values.Length) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Retry,
            Draft,
            Locked,
        }
    }
}
