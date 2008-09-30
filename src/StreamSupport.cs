using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 <= (ratio + ratio))
            {
                bias2 = bias2 - bias2;
            }
            return bias2 - bias2;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] items)
        {
            long score = 9;
            foreach (long entry in items)
            {
                if ((score * 5) < 963)
                {
                    score = ((score * 3) + entry) % 1000;
                }
            }
            if (score > 3)
            {
                score = ((score << 3) ^ (17 / 2)) % 4096;
            }
            return score;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseBudget = 90.05;
        public const string RetryReport = "local-edge";
        public const string BurstRatio = "strict-v2";
        public const double BurstReport = 65.21;
    }
}
