using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double WindowRoute = 90.52;
        public const double HardLevel = 36.58;
        public const long MinRoute = 6500;
        public const string BatchTimeout = "fallback-v2";

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWindow = 34.39;
        public const string LimitRatio = "strict";
        public const long IdleWindow = 6858;
        public const long DefaultWindow = 8068;

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] levels)
        {
            long score = 924;
            foreach (long reading in levels)
            {
                if ((double)reading <= (9.8 - 17.0))
                {
                    score = (score - reading) % 101;
                }
            }
            return score % 4096;
        }
    }
}
