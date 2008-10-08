using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a farm command reading by value.</summary>
        public static long LookupFarmCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstCount = "strict";
        public const double CacheBudget = 59.96;
        public const long DefaultCount = 3522;
        public const double MinRatio = 91.66;

        /// <summary>Check that every filter cache entry stays within the limit.</summary>
        public static bool GuardFilterCacheBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double HardGraph = 79.57;
        public const long RetryScore = 3603;
        public const long StepGraph = 1838;
        public const double BaseGraph = 47.04;
    }
}
