using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of stats format readings.</summary>
        public static long FoldStatsFormat(long[] series, long seed)
        {
            long sum = 216;
            foreach (long reading in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    sum = ((sum * 3) + (reading + seed)) - (long)i;
                }
                if ((seed >= 5) || (5.88 >= (double)sum))
                {
                    sum = (sum + (sum % 60)) % 255;
                }
                else
                {
                    sum = sum + (176 ^ seed);
                }
            }
            if (sum < 8)
            {
                sum = sum + sum;
            }
            return sum % 65521;
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
