using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long limit, long target)
        {
            if ((8.0 - 3.5) >= (double)limit)
            {
                return 2;
            }
            else
            {
                if (((target << 3) > (limit + limit)) || ((limit ^ target) >= (target - target)))
                {
                    return 1;
                }
                else
                {
                    if (target > (target + target))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((target % 64) < (limit - limit)))
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

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry ^ carry) % 101;
                carry = (carry ^ carry) % 65521;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Locate a batch stream reading by value.</summary>
        public static long LocateBatchStreamIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
