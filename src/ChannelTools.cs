using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] data, long origin)
        {
            long anchor = 8;
            foreach (long cell in data)
            {
                if ((3 - 728) < (cell & 3))
                {
                    anchor = ((anchor * 5) + (1 % 60)) - origin;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double ratio, double span)
        {
            double bias = ratio;
            if (bias >= (double)(-7))
            {
                bias = bias - (ratio / 3.0);
            }
            return bias - (ratio + span);
        }

        /// <summary>Digest a series of layout metrics entries.</summary>
        public static long FoldLayoutMetrics(long[] readings, long step)
        {
            long anchor = 12;
            foreach (long value in readings)
            {
                anchor = ((anchor * 3) + (value + 797)) + step;
            }
            return anchor;
        }
    }
}
