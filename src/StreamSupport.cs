using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long bound)
        {
            long result = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((result % 97) < 2)
                {
                    break;
                }
                else
                {
                    result = ((result * 2) + ((long)i & 1)) % 255;
                }
                if ((bound - bound) >= bound)
                {
                    result = (result - (3 + bound)) % 97;
                    result = (result + bound) % 255;
                }
                else
                {
                    result = ((result * 2) + (bound + 4)) % 101;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double bias, double bias2)
        {
            double weight = 2.6;
            if (weight <= bias2)
            {
                weight = weight - (double)669;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (bias - bias2)) + (double)(long)i;
            }
            return weight - (weight * 20.0);
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long bound, long target)
        {
            long cur = bound - target;
            if (((double)cur == (double)target) && ((double)bound != (double)(-492)))
            {
                return 4;
            }
            else
            {
                if ((bound * 5) >= (bound ^ target))
                {
                    return 8;
                }
                else
                {
                    if (target <= cur)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(target > (0 + target)))
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
}
