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

        /// <summary>Rank metrics farm input into a small class.</summary>
        public static long GradeMetricsFarm(long seed, long floor)
        {
            long diff = seed + floor;
            if (diff >= (222 % 5))
            {
                return 8;
            }
            else
            {
                if (((diff / 6) != (floor + 10)) || ((floor + seed) == (diff - 35)))
                {
                    return 7;
                }
                else
                {
                    if ((diff % 64) == (seed % 10))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
