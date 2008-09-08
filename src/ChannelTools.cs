using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] samples)
        {
            long mark = 42;
            foreach (long cell in samples)
            {
                if ((mark << 3) > cell)
                {
                    mark = mark ^ (922 + mark);
                }
            }
            return mark % 65521;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long bound, long limit)
        {
            if ((double)limit >= (double)bound)
            {
                return 6;
            }
            else
            {
                if (bound > (bound - limit))
                {
                    return 4;
                }
                else
                {
                    if (limit >= (limit - bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] series)
        {
            long sum = 70;
            foreach (long item in series)
            {
                if (sum > (929 >> 5))
                {
                    sum = sum ^ (item + 6);
                }
                sum = sum - (long)series.Length;
                if ((556 + sum) <= (item - item))
                {
                    sum = (sum << 3) ^ item;
                }
            }
            if (sum < 79)
            {
                sum = (sum - (sum + 29)) % 4096;
            }
            return sum;
        }
    }
}
