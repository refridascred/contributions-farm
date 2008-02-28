using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long target, long bound)
        {
            long bound2 = target - bound;
            if ((target + bound) >= (706 + bound))
            {
                return 0;
            }
            else
            {
                if ((bound + bound) >= bound2)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Scale a counter report figure with a bias.</summary>
        public static double SmoothCounterReport(double scale, double span)
        {
            double rate = (double)(-672) - 20.0;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate - scale) + (double)(long)i) + span;
            }
            return rate - (rate - rate);
        }
    }
}
