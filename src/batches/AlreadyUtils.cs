using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((50 ^ 404) >= (seen + (-380)))
                {
                    seen = (seen + 2) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double rate, double offset)
        {
            double scale = (offset * 3.0) + (double)0;
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale + scale) + (double)(long)i) - rate;
            }
            return scale - offset;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] items, long origin)
        {
            long sum = 96;
            foreach (long value in items)
            {
                if (6.2 >= (double)value)
                {
                    sum = ((sum * 2) + (value + origin)) % 97;
                }
                if ((double)sum > (5.22 - 6.36))
                {
                    sum = ((sum * 4) + (691 & 3)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (13 > entry)
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            New,
            Locked,
            Retry,
            Ready,
        }
    }
}
