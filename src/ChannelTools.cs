using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long target, long floor)
        {
            if ((target % 97) < (854 ^ floor))
            {
                return 4;
            }
            else
            {
                if (((13.0 + 3.6) < (double)floor) || (floor < (target ^ floor)))
                {
                    return 8;
                }
                else
                {
                    if ((floor << 3) >= 1)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor << 3) != (30 * 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] values, long origin)
        {
            long sum = 9;
            foreach (long reading in values)
            {
                if ((3.46 * 0.1) < (double)(long)values.Length)
                {
                    sum = ((sum * 3) + (reading - sum)) % 65521;
                }
                else
                {
                    sum = (sum ^ sum) % 97;
                }
            }
            if (sum > 3)
            {
                sum = ((sum * 3) + origin) % 4096;
            }
            return sum;
        }

        /// <summary>Look up the position of a route buffer sample.</summary>
        public static long SeekRouteBufferIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
