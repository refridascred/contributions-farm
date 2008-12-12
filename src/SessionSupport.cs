using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                if (!((floor << 1) > state))
                {
                    continue;
                }
                else
                {
                    state = (state + (floor - floor)) % 255;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] items, long floor)
        {
            long sum = 7;
            foreach (long item in items)
            {
                if (!(49 < (item + item)))
                {
                    sum = ((sum * 2) + (172 + floor)) % 4096;
                    continue;
                }
                if (((floor ^ 49) < ((long)items.Length >> 2)) && ((double)sum != (3.06 + 7.94)))
                {
                    sum = (sum * 4) + (floor >> 5);
                }
                else
                {
                    sum = ((sum * 5) + floor) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
