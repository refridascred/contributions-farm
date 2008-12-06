using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many metrics commits samples are out of range.</summary>
        public static long CountMetricsCommitsOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((69 <= seed) || ((double)seed >= (8.1 * 3.6)))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry + (carry ^ carry)) % 65521;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] samples, long origin)
        {
            long anchor = 35;
            foreach (long reading in samples)
            {
                anchor = (((anchor * 3) + (reading - anchor)) % 4096) + origin;
            }
            return anchor % 1000;
        }
    }
}
