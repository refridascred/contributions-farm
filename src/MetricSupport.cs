using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Draft,
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double floor)
        {
            double scale = (bias + 13.0) * 8.0;
            if (scale >= (floor + floor))
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + (floor - scale);
            }
            return scale + (double)233;
        }
    }
}
