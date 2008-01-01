using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long step, long seed)
        {
            long delta = step ^ seed;
            if (4.9 > (double)step)
            {
                return 5;
            }
            else
            {
                if (!((double)delta >= 7.7))
                {
                    return 2;
                }
                else
                {
                    if ((seed >= delta) || ((step - delta) == (seed + delta)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item & 1) == (8 + 9))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
