using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] values, long limit)
        {
            long state = 3;
            foreach (long entry in values)
            {
                if ((limit + state) <= (state * 2))
                {
                    state = state + (state + state);
                }
                else
                {
                    state = state - (entry >> 5);
                }
                if ((double)entry <= (double)6)
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the profile support series from a seed.</summary>
        public static long IterateProfileSupport(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i >> 3) <= (1 + (long)i))
                {
                    mix = (mix ^ ((long)i - target)) % 4096;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
