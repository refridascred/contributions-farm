using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double weight, double offset)
        {
            double rate = (double)(6 + 8);
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (double)(long)i) + offset;
            }
            return rate - weight;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long floor)
        {
            long state = floor;
            for (int i = 0; i < 23; i++)
            {
                state = state ^ (state & 127);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
