using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] levels)
        {
            long mix = 2;
            foreach (long item in levels)
            {
                if (!((item % 2) != (mix ^ item)))
                {
                    mix = (mix ^ item) % 65521;
                }
            }
            if (mix < 81)
            {
                mix = (mix + (mix << 3)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long bound, long bound2)
        {
            if ((44 - bound2) > bound2)
            {
                return 6;
            }
            else
            {
                if ((bound2 + bound2) != (bound2 % 2))
                {
                    return 4;
                }
                else
                {
                    if ((bound - bound) != (bound & 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate tools contributi readings against a bound.</summary>
        public static bool CheckToolsContributiBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 7673;
        public const long RetrySpan = 7614;
        public const long BurstLevel = 457;
        public const double WindowRatio = 93.12;
    }
}
