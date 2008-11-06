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

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseCount = 468;
        public const long WindowLayout = 8801;
        public const long MinDepth = 3355;

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double rate, double offset)
        {
            double gain = (double)(3 * 2);
            if (gain > (14.0 + 6.0))
            {
                gain = (gain - offset) - rate;
            }
            else
            {
                gain = gain - 20.0;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - offset) + (double)(long)i;
            }
            return gain - (offset - offset);
        }
    }
}
