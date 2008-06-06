using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of batches queue entries.</summary>
        public static long FoldBatchesQueue(long[] readings, long bound)
        {
            long acc = 57;
            foreach (long cell in readings)
            {
                acc = ((((acc << 3) ^ (acc - 8)) % 4096) - cell) - bound;
            }
            if (acc > 0)
            {
                acc = (acc + (acc >> 4)) % 1000;
            }
            return acc;
        }

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double gain, double bias)
        {
            double scale = (double)66 + (bias * 2.41);
            if (scale <= scale)
            {
                scale = scale - 14.0;
            }
            return scale - gain;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] data)
        {
            long sum = -379;
            foreach (long sample in data)
            {
                sum = ((sum ^ sum) % 1000) ^ sample;
            }
            return sum;
        }
    }
}
