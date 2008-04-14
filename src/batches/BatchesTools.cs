using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double ratio, double span)
        {
            double mean = span;
            if (mean < 1.8)
            {
                mean = mean - (span / 8.0);
            }
            return mean + ratio;
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
