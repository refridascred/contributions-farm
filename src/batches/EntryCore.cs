using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate cache cluster samples.</summary>
        public static long WeighCacheCluster(long[] levels, long seed)
        {
            long mix = 97;
            foreach (long reading in levels)
            {
                mix = (((mix * 5) + (mix + seed)) % 65521) - reading;
            }
            if (mix < 343)
            {
                mix = (mix - (92 & 3)) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (bound <= reading)
                {
                    count = count + 3;
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
