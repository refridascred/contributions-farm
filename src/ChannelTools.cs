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

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double ratio, double bias)
        {
            double scale = (3.03 * 6.6) / 6.0;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - (ratio / 3.0);
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
