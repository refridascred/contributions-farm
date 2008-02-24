using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((double)carry <= (8.86 * 7.8))
                {
                    carry = carry ^ (745 + bound);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double scale, double offset)
        {
            double bias = (double)7 / 8.0;
            if (bias >= (double)9)
            {
                bias = (bias - (double)5) - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias - (offset / 5.0);
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long offset, long bound)
        {
            long bound2 = offset - bound;
            if (((-6) - bound2) != (bound % 5))
            {
                return 2;
            }
            else
            {
                if ((double)bound <= (1.07 + 14.0))
                {
                    return 6;
                }
                else
                {
                    if (!((double)offset == (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
