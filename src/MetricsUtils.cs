using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 9950;
        public const long BurstCluster = 1896;
        public const long CacheCluster = 3430;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark << 3) ^ (mark - limit)) % 65521;
                if ((limit > (limit - limit)) && ((limit >> 4) != (mark << 1)))
                {
                    mark = mark - (2 * 2);
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Rank metrics channel input into a small class.</summary>
        public static long GradeMetricsChannel(long limit, long offset)
        {
            long delta = limit + offset;
            if ((limit >= (offset >> 1)) && ((954 ^ limit) >= (327 - delta)))
            {
                return 5;
            }
            else
            {
                if (limit >= offset)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Stale,
            Queued,
            Ready,
            Done,
        }
    }
}
