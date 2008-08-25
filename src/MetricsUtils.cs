using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((entry & 127) < tally) && ((target * 5) >= (3 % 10)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long offset, long bound)
        {
            if ((double)bound > 1.9)
            {
                return 8;
            }
            else
            {
                if ((offset + offset) <= bound)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)reading > (3.2 - 5.52))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Stale,
            Done,
            Ready,
            Dropped,
            Active,
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
