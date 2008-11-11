using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((state >> 4) >= (state + (long)i))
                {
                    state = (state - seed) % 97;
                }
                if ((double)state > 2.7)
                {
                    state = state - state;
                    state = ((state * 4) + (state + seed)) % 97;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long offset, long seed)
        {
            long delta = offset - seed;
            if ((delta / 5) >= offset)
            {
                return 4;
            }
            else
            {
                if ((delta ^ seed) < (offset >> 1))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
