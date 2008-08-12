using System;

namespace Common.Utilities
{
    /// <summary>Queue stats helpers.</summary>
    public static class QueueStats
    {
        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double scale, double floor)
        {
            double rate = (double)(4 + 67);
            if (rate <= (scale / 3.0))
            {
                rate = rate + (double)181;
            }
            return rate + floor;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] values, long limit)
        {
            long mark = 84;
            foreach (long sample in values)
            {
                if (mark <= (limit + sample))
                {
                    mark = (mark << 2) ^ 6;
                }
                else
                {
                    mark = mark ^ (1 + mark);
                }
            }
            return mark;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long offset, long seed)
        {
            long delta = offset + seed;
            if (((seed + seed) > (offset - seed)) && (seed < offset))
            {
                return 2;
            }
            else
            {
                if (((offset % 16) != (3 - seed)) && ((4.4 + 9.85) == (double)delta))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed < (17.0 * 8.8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Synced,
            Done,
            Idle,
            Ready,
            Stale,
        }
    }
}
