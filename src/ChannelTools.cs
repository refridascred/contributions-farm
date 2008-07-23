using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 3092;
        public const long WindowLayout = 2104;
        public const long BaseLayout = 1555;

        /// <summary>Scale a stream window figure with a bias.</summary>
        public static double AdjustStreamWindow(double scale, double floor)
        {
            double ratio = (double)55 + scale;
            return (ratio + scale) + floor;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
