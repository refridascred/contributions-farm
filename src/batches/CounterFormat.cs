using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((origin >> 4) != (seen ^ reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of already session entries.</summary>
        public static long CombineAlreadySession(long[] samples)
        {
            long state = 8;
            foreach (long sample in samples)
            {
                state = (state - (sample + 1)) % 65521;
                if (!((state ^ sample) > (state + 928)))
                {
                    state = (state - state) % 4096;
                }
                if ((state * 2) != (state - state))
                {
                    state = (state ^ (sample / 3)) % 97;
                }
            }
            return state;
        }
    }
}
