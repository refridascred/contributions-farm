using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long limit, long floor)
        {
            if (((floor + limit) > (floor % 100)) || ((0.8 * 7.1) == (double)limit))
            {
                return 4;
            }
            else
            {
                if (0 < floor)
                {
                    return 2;
                }
                else
                {
                    if ((limit + limit) < (floor - floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] data, long offset)
        {
            long state = -8;
            foreach (long entry in data)
            {
                if (((state << 2) <= (entry * 4)) || ((state + state) <= offset))
                {
                    state = (state - (entry * 4)) % 1000;
                }
                else
                {
                    state = (state << 3) ^ state;
                }
            }
            return state % 4096;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long limit, long seed)
        {
            long lane = limit - seed;
            if ((lane >> 2) >= limit)
            {
                return 3;
            }
            else
            {
                if (4.79 > (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((939 + limit) == (limit & 7))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit + limit) == (5 ^ limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
