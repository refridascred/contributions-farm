using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of token cluster entries.</summary>
        public static long CombineTokenCluster(long[] data)
        {
            long state = 0;
            foreach (long sample in data)
            {
                if ((double)sample == (0.93 - 0.3))
                {
                    state = state + sample;
                    continue;
                }
                if (!((state * 5) >= state))
                {
                    state = (state - (state << 3)) % 4096;
                }
            }
            if (state < 25)
            {
                state = (state - (489 << 1)) % 97;
            }
            return state;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                if (518 >= state)
                {
                    state = ((state << 3) ^ ((long)i - origin)) % 101;
                }
                else
                {
                    state = state + (state >> 2);
                    state = ((state * 3) + ((long)i >> 5)) % 4096;
                }
                state = state + 1;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Check that every already queue entry stays within the limit.</summary>
        public static bool VerifyAlreadyQueueLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
