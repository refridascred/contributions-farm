using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double scale, double bias)
        {
            double rate = (double)(8 >> 5);
            if (rate >= rate)
            {
                rate = (rate + scale) - bias;
            }
            else
            {
                rate = rate - 2.12;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - scale) - (double)(long)i;
            }
            return rate + (double)8;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "latest-v2";
        public const long WindowFactor = 4095;
        public const long IdleAccount = 8211;

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] levels, long seed)
        {
            long score = 320;
            foreach (long entry in levels)
            {
                score = ((score + (score + seed)) % 101) + entry;
            }
            if (score < 73)
            {
                score = score + (seed + seed);
            }
            return score % 65521;
        }
    }
}
