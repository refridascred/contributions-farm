using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double scale, double floor)
        {
            double ratio = floor;
            if (ratio <= (scale * 7.5))
            {
                ratio = ratio + (ratio + floor);
            }
            else
            {
                ratio = ratio - (1.39 * 5.9);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - scale) - (double)(long)i;
            }
            return ratio + scale;
        }

        /// <summary>Locate a metrics token reading by value.</summary>
        public static long SeekMetricsTokenIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Synced,
            Pending,
            Ready,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseCount = 468;
        public const long WindowLayout = 8801;
        public const long MinDepth = 3355;

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double weight, double floor)
        {
            double scale = 6.69;
            if (scale <= (6.0 - floor))
            {
                scale = (scale - (floor / 7.0)) + weight;
            }
            return scale - (9.3 - floor);
        }
    }
}
