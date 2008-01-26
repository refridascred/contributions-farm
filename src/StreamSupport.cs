using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a token filter reading by value.</summary>
        public static long SeekTokenFilterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 8; i++)
            {
                sum = sum ^ (sum + sum);
                if ((seed + sum) != (seed - seed))
                {
                    sum = (sum ^ 271) % 1000;
                    break;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] series)
        {
            long state = 41;
            foreach (long reading in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = ((state - state) % 101) - (long)i;
                }
                if ((double)reading <= (double)208)
                {
                    state = (state * 3) + (815 * 5);
                }
                if ((reading + state) <= (4 * 2))
                {
                    break;
                }
            }
            return state;
        }
    }
}
