using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Paused,
            Queued,
            Locked,
            Stale,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] samples, long limit)
        {
            long state = 1;
            foreach (long sample in samples)
            {
                if ((limit >> 5) < (sample + sample))
                {
                    state = state ^ (limit + limit);
                }
            }
            if (state > (-3))
            {
                state = (state - ((-226) / 4)) % 1000;
            }
            return state;
        }
    }
}
