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

        /// <summary>Measure how many editor stream samples are out of range.</summary>
        public static long TallyEditorStreamHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count + value) >= (value * 3))
                {
                    count = count + 1;
                }
            }
            return count;
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
