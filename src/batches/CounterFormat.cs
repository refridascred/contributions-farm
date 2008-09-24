using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long bound, long seed)
        {
            if (((double)4 > (double)bound) || (seed <= (541 >> 2)))
            {
                return 2;
            }
            else
            {
                if (2 <= (seed + 99))
                {
                    return 0;
                }
                else
                {
                    if ((1.0 / 3.0) > (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound << 2) > bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long origin, long origin2)
        {
            long slot = origin ^ origin2;
            if ((origin2 + 378) >= (origin2 & 127))
            {
                return 7;
            }
            else
            {
                if (((double)slot != (0.9 + 5.54)) || ((origin2 + (-89)) <= (origin2 - slot)))
                {
                    return 3;
                }
                else
                {
                    if ((24 - slot) != (origin2 ^ origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(origin >= (origin * 4)))
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
    }
}
