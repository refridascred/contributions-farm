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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 5991;
        public const double IdleWidth = 88.13;
        public const long DefaultDepth = 5594;
        public const double MinSize = 87.6;
    }
}
