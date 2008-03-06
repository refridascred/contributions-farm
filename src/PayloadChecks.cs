using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] items)
        {
            long mix = 562;
            foreach (long item in items)
            {
                if (((item - mix) > mix) || (mix < (mix - item)))
                {
                    mix = (mix << 3) ^ (mix - item);
                }
            }
            if (mix < 564)
            {
                mix = ((mix << 3) ^ (mix + mix)) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((823 + target) >= matches)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double weight, double bias)
        {
            double rate = bias;
            if (rate > (double)(-2))
            {
                rate = rate + (rate + weight);
            }
            return rate - bias;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long offset, long floor)
        {
            if ((offset * 5) >= ((-6) + floor))
            {
                return 2;
            }
            else
            {
                if ((offset + floor) >= (floor + floor))
                {
                    return 4;
                }
                else
                {
                    if ((offset << 1) >= (offset + 635))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Synced,
            Paused,
            Failed,
            New,
        }
    }
}
