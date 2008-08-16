using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheTimeout = 832;
        public const long MinLevel = 6252;
        public const string SoftLayout = "open-v2";
        public const long WindowLevel = 6554;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 8107;
        public const double RetryInterval = 96.75;
        public const string HardEditor = "stable";

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] series, long limit)
        {
            long score = 372;
            foreach (long sample in series)
            {
                score = (((score << 3) ^ (limit + 945)) % 255) ^ sample;
                if ((score + limit) <= limit)
                {
                    score = (score ^ (score - limit)) % 255;
                }
            }
            return score;
        }
    }
}
