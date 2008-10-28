using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long step, long origin)
        {
            if (((5.23 / 3.0) <= (double)step) && ((origin + step) < (step + origin)))
            {
                return 3;
            }
            else
            {
                if ((3 + origin) != (step - origin))
                {
                    return 1;
                }
                else
                {
                    if ((origin + origin) <= origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin + origin) <= step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long offset, long offset2)
        {
            if (offset < (31 - offset))
            {
                return 2;
            }
            else
            {
                if (((offset2 + offset) >= (offset + offset)) && (58 <= offset))
                {
                    return 8;
                }
                else
                {
                    if ((50 ^ offset2) < (offset2 ^ offset))
                    {
                        return 7;
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
