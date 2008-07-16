using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long seed, long origin)
        {
            if (69 > (seed + origin))
            {
                return 7;
            }
            else
            {
                if ((origin % 16) < (origin - seed))
                {
                    return 2;
                }
                else
                {
                    if ((11.0 - 18.0) != (double)seed)
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

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long origin, long origin2)
        {
            if (origin > (origin2 % 64))
            {
                return 7;
            }
            else
            {
                if ((origin2 + origin) == (origin2 * 2))
                {
                    return 3;
                }
                else
                {
                    if (52 > (origin + origin2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (771 > (origin2 + 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the counter token series from a seed.</summary>
        public static long StepCounterToken(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc ^ (71 & 7)) % 65521;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
