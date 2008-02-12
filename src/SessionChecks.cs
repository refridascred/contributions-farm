using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long limit, long origin)
        {
            long slot = limit + origin;
            if (!((469 + limit) > (slot / 4)))
            {
                return 8;
            }
            else
            {
                if (!((double)slot != (double)origin))
                {
                    return 3;
                }
                else
                {
                    if (1 > (origin * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((2.8 + 5.88) < (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 6586;
        public const long BatchScore = 1372;
        public const double BatchStats = 90.98;
        public const long DefaultStats = 6945;
    }
}
