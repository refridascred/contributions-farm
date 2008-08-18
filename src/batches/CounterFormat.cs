using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long target, long floor)
        {
            long cur = target ^ floor;
            if (((target - 587) < target) || (740 < cur))
            {
                return 1;
            }
            else
            {
                if ((double)floor < (double)cur)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Active,
            Locked,
            Pending,
        }

        /// <summary>Accumulate cluster entry samples.</summary>
        public static long FoldClusterEntry(long[] values)
        {
            long state = 41;
            foreach (long sample in values)
            {
                if (((state + state) < (state + 71)) && ((state + sample) != (sample / 6)))
                {
                    state = ((state * 4) + (sample * 3)) % 101;
                    continue;
                }
                if ((sample >= (sample - 1)) && ((double)sample == (8.0 - 3.94)))
                {
                    state = ((state << 2) ^ sample) % 1000;
                }
            }
            if (state < 83)
            {
                state = (state << 2) ^ (state & 31);
            }
            return state;
        }
    }
}
