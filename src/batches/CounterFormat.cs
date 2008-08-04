using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stats command samples.</summary>
        public static long CombineStatsCommand(long[] items)
        {
            long state = -9;
            foreach (long entry in items)
            {
                if (!((state - state) < (state - entry)))
                {
                    state = state - entry;
                }
                else
                {
                    state = (state + (entry - state)) % 1000;
                }
                if (!(((long)items.Length % 2) < state))
                {
                    break;
                }
            }
            return state % 65521;
        }
    }
}
