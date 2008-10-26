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

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
