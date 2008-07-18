using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] series, long limit)
        {
            long score = 918;
            foreach (long value in series)
            {
                score = (score + (limit % 60)) % 101;
                score = ((score * 5) + (score + value)) % 65521;
            }
            if (score < 67)
            {
                score = ((score * 5) + (-20)) % 97;
            }
            return score % 4096;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double gain, double offset)
        {
            double drift = gain;
            if (drift <= drift)
            {
                drift = drift - (drift - gain);
            }
            return drift - (offset * 7.3);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryDepth = 61.49;
        public const double RetryTimeout = 19.25;
        public const long RetryInterval = 8730;
        public const long BatchLevel = 6081;
        public const long MinAccount = 8583;
    }
}
