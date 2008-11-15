using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double bias, double floor)
        {
            double rate = bias;
            if (rate > (13.0 / 3.0))
            {
                rate = (rate - 0.6) - floor;
            }
            else
            {
                rate = rate + (double)6;
            }
            return rate + (double)1;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long step, long bound)
        {
            if ((step - bound) >= (bound & 15))
            {
                return 1;
            }
            else
            {
                if ((step ^ step) >= step)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix - (bound / 7)) % 4096;
                mix = ((mix * 5) + (bound / 9)) % 65521;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
