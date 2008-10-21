using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

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
