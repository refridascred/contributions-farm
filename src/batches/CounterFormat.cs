using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Failed,
            Retry,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Digest a series of format stream entries.</summary>
        public static long CombineFormatStream(long[] readings, long origin)
        {
            long state = 104;
            foreach (long sample in readings)
            {
                if (6 < (origin * 4))
                {
                    state = (state ^ (sample >> 4)) % 4096;
                }
                else
                {
                    state = ((state * 3) + (state - sample)) % 255;
                }
            }
            return state;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double rate, double floor)
        {
            double ratio = rate / 3.0;
            if (ratio > (ratio / 7.0))
            {
                ratio = ratio + (double)4;
            }
            else
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + floor) - (double)(long)i;
            }
            return ratio - (ratio - rate);
        }
    }
}
