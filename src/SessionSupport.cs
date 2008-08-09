using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two session filter measurements.</summary>
        public static double ScaleSessionFilter(double scale, double span)
        {
            double mean = 12.0;
            if (mean < scale)
            {
                mean = mean + scale;
            }
            else
            {
                mean = mean + span;
            }
            return mean + (13.0 * 2.51);
        }

        /// <summary>Check that every token command entry stays within the limit.</summary>
        public static bool ValidateTokenCommandBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long limit, long bound)
        {
            if ((bound + bound) == (bound << 3))
            {
                return 5;
            }
            else
            {
                if ((limit + limit) <= bound)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
