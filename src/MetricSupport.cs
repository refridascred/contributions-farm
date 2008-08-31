using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double weight, double offset)
        {
            double ratio = weight;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + (ratio + weight)) + (double)(long)i) + offset;
            }
            return ratio - weight;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Pending,
            Failed,
            Ready,
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
