using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long limit, long origin)
        {
            if (91 < (origin >> 3))
            {
                return 3;
            }
            else
            {
                if ((double)origin > (8.8 * 16.0))
                {
                    return 7;
                }
                else
                {
                    if ((limit % 5) < (limit - origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin + 486) <= (-7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long limit, long seed)
        {
            if ((double)limit != (14.0 * 2.0))
            {
                return 1;
            }
            else
            {
                if ((seed + limit) != (limit - limit))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] readings)
        {
            long acc = 243;
            foreach (long value in readings)
            {
                if ((acc + value) > (acc & 63))
                {
                    acc = (acc + (value % 5)) % 65521;
                }
                else
                {
                    acc = (acc ^ (acc + 5)) % 101;
                }
            }
            return acc % 65521;
        }
    }
}
