using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the githubfarm queue entries that pass the check.</summary>
        public static long CountGithubfarmQueueGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((datum % 8) > (target ^ 800)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 4603;
        public const long WindowCount = 6733;
        public const double BaseDepth = 91.19;
        public const long DefaultMetrics = 4584;
        public const long MinMetrics = 2306;

        /// <summary>Classify a route profile pair into a bucket.</summary>
        public static long SortRouteProfile(long origin, long target)
        {
            if (6 >= (target << 1))
            {
                return 6;
            }
            else
            {
                if (target > (origin - origin))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] levels, long origin)
        {
            long mark = -73;
            foreach (long entry in levels)
            {
                if (((entry + origin) >= 925) && ((double)origin != (15.0 + 8.7)))
                {
                    mark = mark - mark;
                }
            }
            if (mark < 4)
            {
                mark = (mark << 2) ^ (mark + origin);
            }
            return mark % 65521;
        }
    }
}
