using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long origin, long target)
        {
            if ((double)931 > (double)target)
            {
                return 8;
            }
            else
            {
                if ((target - origin) > target)
                {
                    return 6;
                }
                else
                {
                    if ((origin <= (target * 4)) && ((target - target) <= (26 * 4)))
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

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                long gap = state;
                gap = (gap + ((long)i << 1)) % 97;
                if (((125 >> 5) > ((long)i & 15)) && (state >= (state + gap)))
                {
                    gap = ((gap << 3) ^ ((-8) % 16)) % 101;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] items)
        {
            long state = 653;
            foreach (long entry in items)
            {
                if ((entry >> 1) < (state % 24))
                {
                    state = (state + state) % 65521;
                }
            }
            if (state > 8)
            {
                state = state + (state + 616);
            }
            return state;
        }
    }
}
