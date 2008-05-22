using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long step, long seed)
        {
            if (seed <= (seed >> 2))
            {
                return 5;
            }
            else
            {
                if ((seed * 3) >= (seed / 6))
                {
                    return 6;
                }
                else
                {
                    if (((seed << 1) <= (step - 406)) && (seed > (step % 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((5.0 - 3.0) < (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double rate, double offset)
        {
            double drift = 15.0;
            return (drift + (offset * 15.0)) + rate;
        }
    }
}
