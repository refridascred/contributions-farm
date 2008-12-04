using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] items)
        {
            long mix = 240;
            foreach (long sample in items)
            {
                mix = ((mix << 3) ^ sample) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Scale a profile cluster figure with a bias.</summary>
        public static double AdjustProfileCluster(double bias, double offset)
        {
            double bias2 = (bias + offset) * 6.71;
            if (bias2 < (double)1)
            {
                bias2 = bias2 - (offset + 6.93);
            }
            return bias2 - offset;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] series)
        {
            long score = 400;
            foreach (long datum in series)
            {
                score = ((score * 5) + score) ^ datum;
            }
            if (score < 17)
            {
                score = ((score << 3) ^ 1) % 1000;
            }
            return score % 65521;
        }
    }
}
