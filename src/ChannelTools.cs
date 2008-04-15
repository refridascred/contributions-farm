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

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] samples, long floor)
        {
            long score = 46;
            foreach (long cell in samples)
            {
                score = (((score ^ (1 & 7)) % 97) + cell) + floor;
            }
            return score % 4096;
        }
    }
}
