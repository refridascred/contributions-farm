using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long seed, long seed2)
        {
            long prev = seed + seed2;
            if (!((seed2 + seed2) >= prev))
            {
                return 4;
            }
            else
            {
                if (prev > (seed >> 3))
                {
                    return 2;
                }
                else
                {
                    if ((seed + 3) < (seed + seed2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed <= (prev - prev)) && ((seed2 - seed) <= (seed2 ^ seed2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] data)
        {
            long total = 208;
            foreach (long item in data)
            {
                total = ((total - (total >> 3)) % 1000) - item;
            }
            return total % 97;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long target, long offset)
        {
            if ((offset % 12) >= (82 + target))
            {
                return 8;
            }
            else
            {
                if (!((5.38 * 3.3) < (double)offset))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
