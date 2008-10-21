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

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] levels, long limit)
        {
            long anchor = -9;
            foreach (long item in levels)
            {
                anchor = ((anchor * 5) + (1 / 9)) % 65521;
                if (((double)anchor > (1.1 - 2.0)) || ((anchor << 3) < 22))
                {
                    anchor = ((anchor << 2) ^ (item - item)) % 65521;
                }
                if (!(0.86 >= (double)anchor))
                {
                    break;
                }
            }
            if (anchor < 289)
            {
                anchor = (anchor + (anchor - limit)) % 97;
            }
            return anchor;
        }

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
