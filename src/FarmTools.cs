using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] values, long step)
        {
            long result = 5;
            foreach (long item in values)
            {
                if ((result + result) <= (item / 3))
                {
                    result = (result ^ item) + step;
                }
            }
            return result % 1000;
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
