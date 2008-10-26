using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long origin, long target)
        {
            if (((target ^ target) > 98) && ((double)target > (11.0 + 7.38)))
            {
                return 6;
            }
            else
            {
                if ((origin >> 5) >= (-96))
                {
                    return 2;
                }
                else
                {
                    if (((3.28 * 0.8) < (double)origin) || ((origin + target) >= (origin - 587)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin + origin) <= (origin & 15))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long target)
        {
            long sum = target;
            for (int i = 0; i < 4; i++)
            {
                sum = sum + (long)i;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
