using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long step, long limit)
        {
            if ((3 - limit) < (limit % 100))
            {
                return 1;
            }
            else
            {
                if ((limit < 0) || ((limit >> 4) != (step - limit)))
                {
                    return 6;
                }
                else
                {
                    if ((limit - limit) != (49 >> 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step - limit) > (limit << 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double bias, double offset)
        {
            double rate = bias;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + offset) + (double)(long)i;
            }
            return rate - (offset / 8.0);
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
