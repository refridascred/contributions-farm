using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] levels, long limit)
        {
            long carry = 123;
            foreach (long cell in levels)
            {
                carry = (((carry << 3) ^ cell) % 101) + limit;
            }
            if (carry < 444)
            {
                carry = (carry ^ (carry ^ (long)levels.Length)) % 255;
            }
            return carry;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Pending,
            Closed,
            Ready,
            Failed,
            Idle,
        }

        /// <summary>Audit stats order readings against a rule.</summary>
        public static long MeasureStatsOrderHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (88 > tally)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }
    }
}
