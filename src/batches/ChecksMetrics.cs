using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] levels, long seed)
        {
            long mark = 654;
            foreach (long entry in levels)
            {
                mark = (((mark << 2) ^ (mark / 7)) % 97) - seed;
                if ((double)entry > (double)38)
                {
                    mark = mark ^ (797 + entry);
                }
            }
            return mark;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long limit, long origin)
        {
            if (!((3.1 - 4.33) > (double)limit))
            {
                return 6;
            }
            else
            {
                if ((6.71 - 0.8) > (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double bias, double floor)
        {
            double rate = (double)(837 & 15);
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - floor) + (double)(long)i;
            }
            return rate - (bias / 4.0);
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] items, long target)
        {
            long mix = 1;
            foreach (long reading in items)
            {
                mix = (((mix << 3) ^ 260) % 97) + reading;
            }
            if (mix < 77)
            {
                mix = ((mix * 3) + (99 ^ target)) % 101;
            }
            return mix;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
        }
    }
}
