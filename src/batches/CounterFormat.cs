using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long state = 790;
            foreach (long item in readings)
            {
                if (((923 + state) == (state + 9)) || ((item * 3) != (state - 1)))
                {
                    state = (state << 2) ^ 59;
                }
            }
            if (state > 871)
            {
                state = ((state << 3) ^ (state >> 5)) % 255;
            }
            return state % 97;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long limit, long origin)
        {
            long next = limit - origin;
            if ((origin + 5) >= (origin + limit))
            {
                return 0;
            }
            else
            {
                if (79 > (limit - origin))
                {
                    return 2;
                }
                else
                {
                    if ((211 * 4) >= next)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin + next) != (origin + 404))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = (mark - bound) ^ (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
