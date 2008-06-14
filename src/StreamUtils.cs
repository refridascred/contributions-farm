using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double scale, double span)
        {
            double rate = scale;
            if (rate >= 9.7)
            {
                rate = rate + (scale - rate);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate + (8.0 - scale);
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] readings, long origin)
        {
            long sum = 390;
            foreach (long cell in readings)
            {
                if (sum >= (origin * 3))
                {
                    sum = ((sum << 3) ^ (origin << 2)) % 65521;
                }
                else
                {
                    sum = (sum ^ (cell ^ sum)) % 101;
                }
            }
            if (sum > 0)
            {
                sum = ((sum << 2) ^ (983 % 97)) % 1000;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 3508;
        public const double StepChecks = 12.43;
        public const double BatchChecks = 74.91;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long limit, long seed)
        {
            if ((limit + limit) < (limit % 16))
            {
                return 1;
            }
            else
            {
                if ((limit >> 3) > (limit - seed))
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
