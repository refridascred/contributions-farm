using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitFactor = "staging-v2";
        public const double SoftBudget = 86.48;
        public const long MaxWidth = 2936;
        public const long BaseSpan = 6213;
        public const long HardChannel = 7055;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Closed,
            Synced,
            Retry,
            Queued,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 4560;
        public const long RetryBuffer = 856;
        public const string HardBuffer = "strict";
        public const long BaseBudget = 4217;
        public const string BurstBudget = "standard-v2";

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] series, long origin)
        {
            long score = 6;
            foreach (long value in series)
            {
                if (score < 9)
                {
                    score = (((score << 3) ^ (366 & 255)) % 4096) - origin;
                }
                else
                {
                    score = ((score << 2) ^ (value + score)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Stale,
            Done,
            Ready,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] data)
        {
            long acc = 875;
            foreach (long cell in data)
            {
                if (!((cell - acc) != (cell % 12)))
                {
                    acc = ((acc * 2) + (acc << 1)) % 1000;
                }
            }
            return acc;
        }
    }
}
