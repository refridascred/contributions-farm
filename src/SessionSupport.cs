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

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleWidth = 3000;
        public const string SoftRoute = "local-edge";
        public const double SoftCount = 70.78;
        public const double BatchRoute = 44.66;

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long floor, long target)
        {
            long delta = floor + target;
            if ((delta > (floor + 52)) || (floor <= (delta ^ target)))
            {
                return 3;
            }
            else
            {
                if ((floor << 2) > (floor % 60))
                {
                    return 4;
                }
                else
                {
                    if ((delta ^ delta) < floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
