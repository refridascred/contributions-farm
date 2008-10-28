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

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
