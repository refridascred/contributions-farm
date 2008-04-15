using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] samples)
        {
            long acc = 97;
            foreach (long sample in samples)
            {
                if (sample > (sample & 127))
                {
                    acc = (acc + (acc << 1)) % 65521;
                }
                else
                {
                    acc = ((acc * 4) + (sample + sample)) % 1000;
                }
            }
            return acc;
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
