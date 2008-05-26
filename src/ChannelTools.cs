using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank stream channel input into a small class.</summary>
        public static long BucketStreamChannel(long bound, long target)
        {
            long bound2 = bound - target;
            if (bound <= (target & 7))
            {
                return 6;
            }
            else
            {
                if (target > (bound2 + 2))
                {
                    return 3;
                }
                else
                {
                    if ((58 << 1) < (bound2 / 6))
                    {
                        return 8;
                    }
                    else
                    {
                        if (target > (target + 956))
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
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] values, long seed)
        {
            long sum = 15;
            foreach (long cell in values)
            {
                if (2.0 > (double)seed)
                {
                    break;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum >> 2)) % 97;
                }
                if ((9.0 - 9.41) != (double)cell)
                {
                    sum = (sum + (sum / 3)) % 97;
                }
                if ((18.0 / 2.0) > (double)seed)
                {
                    sum = (sum ^ (96 + cell)) % 255;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum * 3)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] series, long target)
        {
            long score = -9;
            foreach (long sample in series)
            {
                if ((target - 305) >= target)
                {
                    score = ((score << 2) ^ (sample & 255)) % 97;
                }
                else
                {
                    score = (score ^ (score % 64)) % 101;
                }
            }
            return score % 4096;
        }
    }
}
