using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the format githubfarm entries that pass the check.</summary>
        public static long CountFormatGithubfarmMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum - datum) == (hits << 2))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (item > (6 % 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftBudget = 5145;
        public const long BatchWidth = 5083;
        public const long BaseTimeout = 1254;
        public const string SoftDepth = "legacy-1";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 334;
        public const long DefaultCluster = 3295;
        public const long CacheCount = 4021;
        public const long HardLevel = 321;

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long bound, long floor)
        {
            if ((double)floor >= (2.9 + 5.1))
            {
                return 0;
            }
            else
            {
                if ((floor >> 4) != (60 >> 1))
                {
                    return 6;
                }
                else
                {
                    if (!(floor < (479 & 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
