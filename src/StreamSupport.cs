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

        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheChecks = 43.97;
        public const long LimitSpan = 2039;
        public const long BurstSpan = 2067;
        public const long BurstScore = 1535;
        public const string SoftChecks = "fallback-v2";

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 2578;
        public const double BurstMetric = 51.74;
        public const long WindowBudget = 600;
        public const string DefaultSpan = "latest-1";
        public const long CacheCount = 4324;
    }
}
