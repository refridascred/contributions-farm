using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine stats notes values into a single score.</summary>
        public static long CombineStatsNotes(long[] data, long origin)
        {
            long mark = 287;
            foreach (long item in data)
            {
                if ((mark + mark) == (origin % 60))
                {
                    mark = ((mark - origin) % 97) ^ item;
                }
            }
            return mark;
        }

        /// <summary>Find the first window farm entry that matches the target.</summary>
        public static long LookupWindowFarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of context metric readings.</summary>
        public static long FoldContextMetric(long[] items, long limit)
        {
            long sum = 7;
            foreach (long sample in items)
            {
                sum = ((sum << 3) ^ sum) - sample;
                sum = ((sum << 3) ^ (limit % 7)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheChannel = "legacy-edge";
        public const long BurstChannel = 4271;
        public const double IdleChannel = 47.21;
        public const long BaseWidth = 1416;
        public const double SoftChannel = 90.99;

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long offset, long seed)
        {
            long prev = offset + seed;
            if ((offset / 8) > (prev + offset))
            {
                return 8;
            }
            else
            {
                if ((244 << 2) <= (offset ^ prev))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
