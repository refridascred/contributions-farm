using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long bound, long limit)
        {
            long prev = bound - limit;
            if (((limit * 4) < (limit % 7)) && (7 > (limit + 623)))
            {
                return 7;
            }
            else
            {
                if ((prev >> 5) < (prev + (-20)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)datum == (double)hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheLevel = 3873;
        public const long RetryCount = 2977;
        public const string MaxDepth = "fallback-v2";
        public const string MaxWidth = "stable-v2";
        public const long BaseToken = 2956;
    }
}
