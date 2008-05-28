using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long bound, long target)
        {
            long offset = bound ^ target;
            if (!((offset / 7) >= (target >> 4)))
            {
                return 7;
            }
            else
            {
                if (((5.26 / 8.0) >= (double)offset) && (offset >= (offset + bound)))
                {
                    return 1;
                }
                else
                {
                    if (target > (offset + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate already commits samples.</summary>
        public static long FoldAlreadyCommits(long[] levels)
        {
            long mix = 0;
            foreach (long cell in levels)
            {
                if ((9.54 <= (double)cell) || ((mix >> 4) <= (64 + mix)))
                {
                    mix = (mix + (mix + cell)) % 4096;
                }
            }
            if (mix < 550)
            {
                mix = ((mix << 3) ^ (mix + mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double weight, double floor)
        {
            double mean = floor / 4.0;
            if (mean >= floor)
            {
                mean = (mean - (11.0 * 1.53)) - weight;
            }
            else
            {
                mean = mean + 19.0;
            }
            return mean + 10.0;
        }
    }
}
