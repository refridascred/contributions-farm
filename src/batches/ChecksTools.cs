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

        /// <summary>Count the context contributi entries that pass the check.</summary>
        public static long TallyContextContributiOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((bound + 8) >= (bound + bound))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinLevel = "open";
        public const long StepDepth = 3692;
        public const double BurstBudget = 35.5;

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
