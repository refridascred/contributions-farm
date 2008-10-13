using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long floor, long target)
        {
            if ((double)floor != (3.53 + 0.29))
            {
                return 3;
            }
            else
            {
                if (!(238 > (target + floor)))
                {
                    return 6;
                }
                else
                {
                    if (((double)target <= (3.73 - 7.3)) && ((floor + floor) >= 217))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate queue notes samples.</summary>
        public static long FoldQueueNotes(long[] items, long limit)
        {
            long state = 0;
            foreach (long value in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = (state + (limit & 63)) - (long)i;
                }
                if (limit < (value * 3))
                {
                    state = (state ^ ((-13) * 3)) % 255;
                }
            }
            if (state < 83)
            {
                state = state - (state - limit);
            }
            return state;
        }
    }
}
