using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] series)
        {
            long state = -2;
            foreach (long entry in series)
            {
                if (!((double)entry >= (double)state))
                {
                    state = (state - (state + entry)) % 65521;
                }
                else
                {
                    state = (state - 41) % 1000;
                }
            }
            if (state > 702)
            {
                state = ((state << 2) ^ (state / 2)) % 4096;
            }
            return state;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long limit)
        {
            long score = limit;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long limit, long bound)
        {
            long cur = limit ^ bound;
            if ((2.4 * 3.22) < (double)cur)
            {
                return 3;
            }
            else
            {
                if ((cur - limit) <= (cur << 1))
                {
                    return 6;
                }
                else
                {
                    if ((cur % 10) > (bound ^ bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
