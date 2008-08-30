using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchLevel = 668;
        public const long DefaultTools = 3302;
        public const string HardInterval = "cached-v2";

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first graph farm entry that matches the target.</summary>
        public static long LookupGraphFarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((28 ^ cell) != (floor - count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate metrics entry readings against a bound.</summary>
        public static bool CheckMetricsEntryRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
