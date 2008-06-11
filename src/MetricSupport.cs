using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double scale, double offset)
        {
            double bias = (double)(8 >> 4);
            if (bias > bias)
            {
                bias = ((bias + bias) - scale) - offset;
            }
            else
            {
                bias = bias - (bias - 3.0);
            }
            return bias - bias;
        }

        /// <summary>Count tools report pairs that satisfy a relation.</summary>
        public static long OverlapToolsReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Idle,
            Draft,
            Done,
        }
    }
}
