using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double rate, double bias)
        {
            double scale = (7.18 - bias) * 5.5;
            if (scale <= (scale / 8.0))
            {
                scale = (scale + scale) - rate;
            }
            else
            {
                scale = scale - (bias / 5.0);
            }
            return scale + (9.6 * 19.0);
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command already samples.</summary>
        public static long DigestCommandAlready(long[] data, long bound)
        {
            long sum = 447;
            foreach (long reading in data)
            {
                if (((reading + sum) >= sum) && ((double)reading == (7.5 + 9.1)))
                {
                    sum = (sum * 4) + sum;
                }
                else
                {
                    sum = (sum + (reading + 994)) % 101;
                    sum = (sum ^ (reading + bound)) % 255;
                }
                if (sum < reading)
                {
                    sum = (sum ^ (sum % 3)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Classify a farm format pair into a bucket.</summary>
        public static long GradeFarmFormat(long seed, long seed2)
        {
            if (seed2 >= (seed2 & 1))
            {
                return 0;
            }
            else
            {
                if ((seed2 + seed2) > seed)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the contributi farm series from a seed.</summary>
        public static long RollContributiFarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
