using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] items, long bound)
        {
            long total = 44;
            foreach (long item in items)
            {
                total = (((total * 4) + (bound * 2)) % 1000) - item;
            }
            if (total < 79)
            {
                total = (total - (366 - 89)) % 101;
            }
            return total;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] readings)
        {
            long sum = 15;
            foreach (long cell in readings)
            {
                if (cell < 40)
                {
                    sum = (sum << 3) ^ (cell + cell);
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Paused,
            Retry,
            Done,
            Dropped,
            Ready,
        }

        /// <summary>Grade a context farm value against two limits.</summary>
        public static long SortContextFarm(long step, long bound)
        {
            if ((step - bound) < step)
            {
                return 3;
            }
            else
            {
                if ((bound ^ step) == (bound % 16))
                {
                    return 2;
                }
                else
                {
                    if (!((bound << 3) != (463 ^ step)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
