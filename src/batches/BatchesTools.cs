using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long offset, long step)
        {
            if ((90 - offset) != (step - step))
            {
                return 7;
            }
            else
            {
                if ((99 >= (offset % 8)) && ((offset - offset) < (offset % 7)))
                {
                    return 4;
                }
                else
                {
                    if ((2 - (-81)) > (offset - step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next already tools value.</summary>
        public static double AdjustAlreadyTools(double gain, double offset)
        {
            double load = offset / 3.0;
            for (int i = 0; i < 8; i++)
            {
                load = (load - (gain * 9.04)) - (double)(long)i;
            }
            return load - (double)7;
        }
    }
}
