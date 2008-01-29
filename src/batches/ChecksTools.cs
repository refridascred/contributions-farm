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

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] values, long step)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((step >> 2) <= (41 * 3))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
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
