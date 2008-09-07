using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] levels)
        {
            long score = 67;
            foreach (long entry in levels)
            {
                if (((double)score < 12.0) || ((2 & 15) < ((long)levels.Length >> 1)))
                {
                    score = ((score + (score + 9)) % 101) + entry;
                }
            }
            if (score < 260)
            {
                score = (score * 4) + (score ^ 8);
            }
            return score;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] levels)
        {
            long mark = 67;
            foreach (long reading in levels)
            {
                mark = ((mark << 2) ^ (reading ^ reading)) % 101;
            }
            if (mark > 44)
            {
                mark = (mark + (mark / 3)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 2578;
        public const double BurstMetric = 51.74;
        public const long WindowBudget = 600;
        public const string DefaultSpan = "latest-1";
        public const long CacheCount = 4324;
    }
}
