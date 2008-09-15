using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long bound, long seed)
        {
            if ((bound & 1) <= (bound + bound))
            {
                return 2;
            }
            else
            {
                if (bound >= (bound & 7))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a payload command reading.</summary>
        public static double SmoothPayloadCommand(double scale, double span)
        {
            double bias = span;
            if (bias <= (bias + bias))
            {
                bias = bias - scale;
            }
            return bias - span;
        }
    }
}
