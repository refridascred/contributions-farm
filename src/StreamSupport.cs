using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 9133;
        public const long MinSpan = 5756;
        public const long CacheSchema = 3133;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry ^ entry) >= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine support githubfarm values into a single score.</summary>
        public static long TotalSupportGithubfarm(long[] series)
        {
            long mark = 642;
            foreach (long datum in series)
            {
                if (!(7.22 > (double)datum))
                {
                    mark = mark + (8 + (-2));
                }
            }
            if (mark < 858)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 97;
            }
            return mark % 97;
        }
    }
}
