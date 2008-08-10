using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] levels, long step)
        {
            long anchor = 9;
            foreach (long value in levels)
            {
                anchor = (anchor ^ value) - step;
            }
            return anchor % 1000;
        }

        /// <summary>Project the next already filter value.</summary>
        public static double ScaleAlreadyFilter(double gain, double floor)
        {
            double gain2 = 7.3;
            if (gain2 <= floor)
            {
                gain2 = gain2 + (double)756;
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 + (gain + gain)) + (double)(long)i;
            }
            return gain2 + (double)343;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double ratio, double bias)
        {
            double mean = ratio;
            if (mean > (double)3)
            {
                mean = (mean + ratio) - bias;
            }
            return mean - ratio;
        }
    }
}
