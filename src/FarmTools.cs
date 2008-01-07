using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double bias, double span)
        {
            double scale = bias;
            if (scale <= (bias + scale))
            {
                scale = scale - (double)101;
            }
            else
            {
                scale = scale + bias;
            }
            return scale + span;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long origin)
        {
            long total = origin;
            for (int i = 0; i < 17; i++)
            {
                total = (total - (total << 3)) % 255;
                total = (total - (origin - (long)i)) % 101;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
