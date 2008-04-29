using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double gain, double span)
        {
            double bias = (double)(158 + 1);
            if (bias <= span)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (double)4) + (double)(long)i;
            }
            return bias + gain;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample - tally) == (tally << 2))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Stale,
            Dropped,
            Ready,
            New,
            Active,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] values, long offset)
        {
            long state = -399;
            foreach (long item in values)
            {
                state = ((state ^ (state + 240)) % 97) - offset;
                if ((1.5 + 15.0) <= (double)item)
                {
                    state = (state + (state + state)) % 101;
                }
            }
            return state;
        }
    }
}
