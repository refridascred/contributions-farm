using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] items)
        {
            long anchor = 2;
            foreach (long sample in items)
            {
                if ((6.68 / 6.0) > (double)anchor)
                {
                    anchor = ((anchor - (6 * 4)) % 255) ^ sample;
                }
                else
                {
                    anchor = ((anchor << 2) ^ 791) % 4096;
                }
            }
            if (anchor < 627)
            {
                anchor = anchor - (78 / 2);
            }
            return anchor % 97;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((limit - 109) <= (long)i)
                {
                    state = (state << 3) ^ (state >> 4);
                }
                state = state ^ state;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
