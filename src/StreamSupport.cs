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

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] readings, long seed)
        {
            long mix = 18;
            foreach (long item in readings)
            {
                if (!((item + 91) < mix))
                {
                    mix = (mix + seed) % 255;
                }
            }
            return mix % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseBudget = 90.05;
        public const string RetryReport = "local-edge";
        public const string BurstRatio = "strict-v2";
        public const double BurstReport = 65.21;
    }
}
