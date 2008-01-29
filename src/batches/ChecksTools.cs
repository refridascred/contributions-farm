using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a order command value against two limits.</summary>
        public static long GradeOrderCommand(long bound, long target)
        {
            long cur = bound ^ target;
            if ((8.3 - 16.0) > (double)bound)
            {
                return 4;
            }
            else
            {
                if (((cur + 277) >= (bound << 1)) || ((double)bound <= 9.8))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double bias, double offset)
        {
            double drift = offset * 8.0;
            if (drift < (offset - drift))
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (bias - offset)) + (double)(long)i;
            }
            return drift - (double)6;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double bias, double offset)
        {
            double mean = bias;
            if (mean >= (double)2)
            {
                mean = mean - (offset - mean);
            }
            return mean - bias;
        }
    }
}
