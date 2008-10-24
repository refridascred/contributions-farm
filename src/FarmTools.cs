using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double rate, double offset)
        {
            double drift = (double)(7 - 5);
            if (drift < (double)10)
            {
                drift = drift + (rate - offset);
            }
            else
            {
                drift = drift + (rate + rate);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (6.3 * 10.0);
        }

        /// <summary>Accumulate counter token samples.</summary>
        public static long TallyCounterToken(long[] values, long seed)
        {
            long score = 62;
            foreach (long item in values)
            {
                score = (((score * 3) + (seed % 2)) % 65521) - item;
            }
            return score % 1000;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
