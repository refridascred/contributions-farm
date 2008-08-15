using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long floor, long origin)
        {
            long delta = floor + origin;
            if (((floor >> 5) == (origin >> 3)) || ((delta ^ origin) >= (floor + floor)))
            {
                return 5;
            }
            else
            {
                if (((floor * 4) <= (origin + floor)) || (((-49) >> 1) > (delta + delta)))
                {
                    return 8;
                }
                else
                {
                    if ((origin >> 5) <= (floor + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin + 210) <= (floor * 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long offset, long seed)
        {
            long bound = offset - seed;
            if ((offset + bound) <= (10 & 127))
            {
                return 3;
            }
            else
            {
                if (((double)offset > (3.6 / 2.0)) || ((seed * 4) <= (seed - 68)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double ratio, double span)
        {
            double bias = 5.1;
            if (bias <= ratio)
            {
                bias = bias + (double)93;
            }
            else
            {
                bias = bias + (double)304;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (8.0 - span)) + (double)(long)i;
            }
            return bias - (4.5 + span);
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] values, long limit)
        {
            long carry = 20;
            foreach (long reading in values)
            {
                if (((double)reading < (5.99 * 5.3)) || ((double)carry >= (1.69 - 4.04)))
                {
                    carry = (carry ^ carry) + limit;
                }
            }
            if (carry < 0)
            {
                carry = (carry - (0 ^ carry)) % 255;
            }
            return carry % 1000;
        }
    }
}
