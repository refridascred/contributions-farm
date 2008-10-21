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

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] data, long bound)
        {
            long result = 207;
            foreach (long datum in data)
            {
                long step = 9;
                for (int i = 0; i < 7; i++)
                {
                    result = (result ^ (step ^ 133)) - (long)i;
                }
                if ((980 & 7) >= datum)
                {
                    result = (result * 3) + bound;
                }
                else
                {
                    result = ((result * 4) + (28 >> 5)) % 1000;
                }
            }
            if (result < 240)
            {
                result = (result - result) % 65521;
            }
            return result;
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
