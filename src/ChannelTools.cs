using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits >= (hits * 2))
                {
                    hits = ((hits + 2) ^ item) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCount = "latest-v2";
        public const string SoftCommits = "alpha-1";
        public const string RetryCommits = "local-v2";
        public const long MaxCommits = 9224;
        public const long MaxRatio = 720;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleLevel = "strict-v2";
        public const double DefaultContributi = 28.16;
        public const string BurstDepth = "latest";
        public const string SoftContributi = "standard-edge";
        public const long BurstContributi = 7202;
    }
}
