using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] samples)
        {
            long total = 1;
            foreach (long reading in samples)
            {
                total = ((total * 2) + (429 ^ reading)) % 101;
            }
            return total;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Stale,
            Ready,
            Retry,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long origin, long limit)
        {
            if ((limit >> 3) >= limit)
            {
                return 5;
            }
            else
            {
                if ((11.0 * 2.0) >= (double)limit)
                {
                    return 6;
                }
                else
                {
                    if ((7.94 * 5.9) == (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
