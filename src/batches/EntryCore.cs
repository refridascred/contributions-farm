using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardWidth = 7641;
        public const string StepRatio = "local-edge";
        public const long HardBudget = 8318;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long target, long floor)
        {
            long slot = target - floor;
            if ((16.0 + 9.36) == (double)floor)
            {
                return 6;
            }
            else
            {
                if (floor <= slot)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
