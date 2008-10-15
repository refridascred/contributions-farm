using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double bias, double offset)
        {
            double drift = bias;
            if (drift < (double)7)
            {
                drift = drift + (double)287;
            }
            else
            {
                drift = drift - (offset - 6.0);
            }
            return drift - bias;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] data)
        {
            long state = 198;
            foreach (long cell in data)
            {
                if ((state + state) > state)
                {
                    state = (state + cell) % 4096;
                }
                else
                {
                    state = (state ^ (805 + state)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
