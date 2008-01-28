using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long seed, long seed2)
        {
            if ((38 / 4) >= seed2)
            {
                return 7;
            }
            else
            {
                if ((seed % 100) > seed)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
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

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long limit, long step)
        {
            if ((limit >> 4) != (step + limit))
            {
                return 6;
            }
            else
            {
                if ((step * 2) < (step << 3))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
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
