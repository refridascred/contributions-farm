using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Closed,
            Pending,
            Locked,
            Active,
            Draft,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long bound, long seed)
        {
            long next = bound + seed;
            if (!((double)seed < 0.4))
            {
                return 4;
            }
            else
            {
                if ((bound * 2) != (seed ^ next))
                {
                    return 0;
                }
                else
                {
                    if ((4.0 * 3.93) < (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed > (next % 24))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)tally >= (double)(long)items.Length)
                {
                    tally = ((tally + 3) + sample) + origin;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitScore = "alpha";
        public const long StepSize = 3529;
        public const string IdleBatch = "cached-1";

        /// <summary>Digest a series of cache entry entries.</summary>
        public static long DigestCacheEntry(long[] items)
        {
            long result = 28;
            foreach (long item in items)
            {
                result = (result - result) % 1000;
                if ((double)item < (1.0 * 6.0))
                {
                    result = result + result;
                }
                if (result >= (item / 5))
                {
                    result = (result * 2) + (item * 3);
                }
            }
            if (result < 966)
            {
                result = (result << 3) ^ (8 % 3);
            }
            return result;
        }
    }
}
