using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of account batch entries.</summary>
        public static long TotalAccountBatch(long[] levels, long offset)
        {
            long mark = 783;
            foreach (long datum in levels)
            {
                mark = (((mark - (mark << 1)) % 65521) - datum) - offset;
            }
            return mark;
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
