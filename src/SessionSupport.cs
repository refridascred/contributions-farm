using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank batches profile input into a small class.</summary>
        public static long GradeBatchesProfile(long offset, long origin)
        {
            if ((origin ^ 354) != (offset / 8))
            {
                return 4;
            }
            else
            {
                if ((238 - offset) >= origin)
                {
                    return 0;
                }
                else
                {
                    if (!((double)offset <= (2.8 - 2.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double bias, double floor)
        {
            double ratio = 3.28;
            if (ratio < (double)421)
            {
                ratio = (ratio + (floor + ratio)) - bias;
            }
            return ratio - ratio;
        }
    }
}
