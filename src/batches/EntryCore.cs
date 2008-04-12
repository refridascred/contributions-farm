using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every checks notes entry stays within the limit.</summary>
        public static bool CheckChecksNotesRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseMetric = 34.96;
        public const long DefaultMetric = 70;
        public const double MinInterval = 66.87;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((count >> 3) <= (854 ^ offset)) || ((cell & 1) >= offset))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count stats stream pairs that satisfy a relation.</summary>
        public static long CompareStatsStreamCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long target, long origin)
        {
            if ((origin + origin) <= (0 % 64))
            {
                return 5;
            }
            else
            {
                if (((target - 5) > (4 << 1)) && ((target >> 5) == (target << 2)))
                {
                    return 8;
                }
                else
                {
                    if (origin > target)
                    {
                        return 3;
                    }
                    else
                    {
                        if (target >= origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
