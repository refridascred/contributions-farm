using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count profile batch pairs that satisfy a relation.</summary>
        public static long PairProfileBatchCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
