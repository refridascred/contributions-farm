using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double bias, double span)
        {
            double rate = (double)(5 + 21);
            if (rate >= rate)
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (bias * 2.0)) + (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Count the order format entries that pass the check.</summary>
        public static long TallyOrderFormatMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((double)reading < (double)seed) || ((seed < (seed + reading)) || ((reading - seed) < seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
