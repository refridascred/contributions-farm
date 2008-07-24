using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long floor, long origin)
        {
            if (((double)floor >= (4.8 - 3.3)) && ((origin ^ 97) <= (origin * 5)))
            {
                return 7;
            }
            else
            {
                if ((floor - floor) > (floor * 5))
                {
                    return 8;
                }
                else
                {
                    if ((floor << 2) != (floor + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double scale, double offset)
        {
            double bias = (double)(-29) / 4.0;
            for (int i = 0; i < 7; i++)
            {
                bias = (((bias - (double)5) + (double)(long)i) - scale) - offset;
            }
            return bias + bias;
        }
    }
}
