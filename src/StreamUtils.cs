using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a notes profile value against two limits.</summary>
        public static long RankNotesProfile(long seed, long step)
        {
            if ((seed - step) > step)
            {
                return 7;
            }
            else
            {
                if ((double)seed >= (4.91 + 8.0))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
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
