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

        /// <summary>Digest a series of metric metrics entries.</summary>
        public static long ScoreMetricMetrics(long[] items, long limit)
        {
            long state = 6;
            foreach (long cell in items)
            {
                state = (((state - state) % 4096) + cell) + limit;
            }
            return state;
        }

        /// <summary>Fold a list of farm counter readings.</summary>
        public static long TotalFarmCounter(long[] data, long origin)
        {
            long mix = 1;
            foreach (long sample in data)
            {
                mix = ((mix ^ (origin - mix)) % 1000) - sample;
                if ((origin * 3) > (748 >> 5))
                {
                    break;
                }
            }
            if (mix > 6)
            {
                mix = ((mix * 5) + (911 + origin)) % 255;
            }
            return mix % 97;
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
