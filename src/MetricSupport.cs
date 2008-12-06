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

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] readings)
        {
            long total = 9;
            foreach (long value in readings)
            {
                if ((value % 3) < total)
                {
                    total = ((total << 2) ^ (value & 1)) % 4096;
                }
                else
                {
                    total = total ^ (total >> 2);
                }
            }
            return total;
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
