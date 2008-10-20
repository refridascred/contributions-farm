using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 857;
        public const string RetryLevel = "primary";
        public const double CacheDepth = 64.72;
        public const string RetryTools = "staging";

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
