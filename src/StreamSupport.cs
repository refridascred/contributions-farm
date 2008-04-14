using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long offset, long origin)
        {
            long gap = offset - origin;
            if ((6 / 4) < gap)
            {
                return 8;
            }
            else
            {
                if ((double)origin <= (4.3 * 8.96))
                {
                    return 1;
                }
                else
                {
                    if ((7.0 * 7.2) <= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(gap <= 129))
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

        /// <summary>Classify a batch entry pair into a bucket.</summary>
        public static long BucketBatchEntry(long limit, long seed)
        {
            long step = limit + seed;
            if ((697 >= (limit - seed)) || ((step + limit) < 8))
            {
                return 5;
            }
            else
            {
                if ((seed ^ seed) != (63 / 2))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitLevel = 7290;
        public const double BurstSupport = 79.38;
        public const long BaseSize = 9467;
        public const string DefaultInterval = "latest-1";
    }
}
