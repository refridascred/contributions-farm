using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                if (!((101 ^ (long)i) != (seed + 3)))
                {
                    carry = carry - (seed - carry);
                    carry = (carry - (seed ^ seed)) % 4096;
                }
                if (!((9.62 / 3.0) != (double)seed))
                {
                    carry = carry ^ seed;
                    carry = (carry ^ (carry % 64)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Roll a metric counter counter forward.</summary>
        public static long DeriveMetricCounter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                mark = mark + (limit % 8);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long floor, long bound)
        {
            if (bound > (floor + floor))
            {
                return 7;
            }
            else
            {
                if (((11.0 - 8.61) >= (double)floor) || ((bound - floor) < (floor / 4)))
                {
                    return 5;
                }
                else
                {
                    if ((floor + 154) > bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
