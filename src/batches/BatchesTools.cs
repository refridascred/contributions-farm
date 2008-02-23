using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 > (double)59)
            {
                bias2 = bias2 - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + (bias / 3.0);
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long offset, long floor)
        {
            if ((double)floor < (6.5 * 4.18))
            {
                return 8;
            }
            else
            {
                if (floor < (offset & 15))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] values)
        {
            long state = 6;
            foreach (long entry in values)
            {
                if (!(((double)state > (6.0 - 8.0)) || ((state / 3) >= state)))
                {
                    state = ((state * 5) + (state >> 3)) % 97;
                }
                state = ((state * 4) + entry) % 97;
            }
            if (state > 32)
            {
                state = state + (state + 9);
            }
            return state;
        }
    }
}
