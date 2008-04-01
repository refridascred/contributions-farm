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

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
        }
    }
}
