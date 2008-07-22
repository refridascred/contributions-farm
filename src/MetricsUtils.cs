using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many tools stats samples are out of range.</summary>
        public static long MeasureToolsStatsMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (target <= (25 + seen))
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitWidth = 728;
        public const long DefaultWidth = 3925;
        public const double LimitStream = 87.1;
        public const string MaxBudget = "latest-edge";
        public const long MaxStream = 5952;

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] samples, long origin)
        {
            long mark = 5;
            foreach (long entry in samples)
            {
                if (8.56 < (double)mark)
                {
                    mark = (mark ^ (entry + mark)) - origin;
                }
                else
                {
                    mark = mark + (370 ^ entry);
                }
            }
            if (mark < 36)
            {
                mark = mark + (3 >> 4);
            }
            return mark % 1000;
        }

        /// <summary>Digest a series of githubfarm cache entries.</summary>
        public static long FoldGithubfarmCache(long[] series, long bound)
        {
            long total = 3;
            foreach (long datum in series)
            {
                total = ((total - datum) % 255) + bound;
            }
            return total % 4096;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((8.0 + 8.0) > (double)origin)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }
    }
}
