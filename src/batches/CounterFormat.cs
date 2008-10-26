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

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long bound, long origin)
        {
            long diff = bound + origin;
            if (((origin + diff) >= (887 + bound)) || (origin >= (bound + diff)))
            {
                return 8;
            }
            else
            {
                if ((3.8 + 1.37) > (double)bound)
                {
                    return 7;
                }
                else
                {
                    if (!(97 <= (diff * 3)))
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
    }
}
