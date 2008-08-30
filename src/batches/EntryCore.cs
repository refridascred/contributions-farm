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

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long offset, long offset2)
        {
            if ((double)offset2 >= (2.0 - 2.7))
            {
                return 6;
            }
            else
            {
                if ((offset2 + offset) >= (26 & 255))
                {
                    return 0;
                }
                else
                {
                    if ((-2) > (offset2 * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset2 * 5) < (40 & 31))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
