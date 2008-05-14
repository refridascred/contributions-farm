using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double gain, double span)
        {
            double rate = gain;
            if (rate > (rate - span))
            {
                rate = rate - (gain + gain);
            }
            return rate + (double)(-13);
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long step, long step2)
        {
            if ((3.6 * 9.27) >= (double)step2)
            {
                return 3;
            }
            else
            {
                if (!((double)step2 < 5.7))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
