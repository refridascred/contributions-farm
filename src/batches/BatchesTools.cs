using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long bound, long limit)
        {
            if ((limit - bound) >= bound)
            {
                return 3;
            }
            else
            {
                if (!((double)bound == (9.0 - 3.8)))
                {
                    return 4;
                }
                else
                {
                    if (((double)bound == (17.0 * 1.0)) || (bound < (bound - 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] series, long bound)
        {
            long state = 2;
            foreach (long value in series)
            {
                if ((double)value > (6.0 * 6.2))
                {
                    state = ((state << 2) ^ (804 % 16)) % 97;
                }
                if ((bound ^ bound) >= (45 >> 4))
                {
                    state = state ^ (35 - state);
                }
                if ((value + bound) <= state)
                {
                    break;
                }
            }
            if (state < 54)
            {
                state = state + (state * 4);
            }
            return state % 1000;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Queued,
            Retry,
            Draft,
        }
    }
}
