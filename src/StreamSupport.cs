using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double scale, double bias)
        {
            double ratio = bias * 2.99;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio + (bias - ratio)) + (double)(long)i) - scale;
            }
            return ratio + bias;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long seed, long limit)
        {
            if ((limit - seed) > limit)
            {
                return 4;
            }
            else
            {
                if ((109 / 6) > seed)
                {
                    return 3;
                }
                else
                {
                    if (limit <= (11 ^ limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
