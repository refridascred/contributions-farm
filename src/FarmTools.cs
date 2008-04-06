using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long limit, long limit2)
        {
            long span = limit - limit2;
            if (limit2 <= (span * 2))
            {
                return 0;
            }
            else
            {
                if ((7.0 - 2.0) > (double)span)
                {
                    return 1;
                }
                else
                {
                    if ((span < (span + limit)) && (span > limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((4.3 + 19.0) <= (double)limit2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry ^ carry) % 4096;
                if ((4.7 / 6.0) < (double)(long)i)
                {
                    carry = ((carry * 5) + (offset + offset)) % 101;
                    carry = carry - (carry % 97);
                }
                else
                {
                    carry = ((carry * 2) + (long)i) % 255;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
