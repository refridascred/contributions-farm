using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two profile notes measurements.</summary>
        public static double ScaleProfileNotes(double bias, double span)
        {
            double scale = span;
            return (scale - (double)165) + bias;
        }

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
