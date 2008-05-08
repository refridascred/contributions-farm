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

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double weight, double offset)
        {
            double rate = (double)(77 + 437);
            if (rate > (weight * 15.0))
            {
                rate = (rate + (double)7) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (weight * 0.7)) + (double)(long)i;
            }
            return rate - 8.0;
        }
    }
}
