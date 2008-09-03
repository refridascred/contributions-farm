using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 9645;
        public const long LimitCount = 8811;
        public const long HardTimeout = 7906;
        public const double BaseWidth = 33.66;

        /// <summary>Classify a already route pair into a bucket.</summary>
        public static long RankAlreadyRoute(long limit, long seed)
        {
            if (!((3 >> 1) <= (limit * 4)))
            {
                return 1;
            }
            else
            {
                if (!((limit / 8) >= (seed & 255)))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit >= 8.0)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((42 > (limit & 31)) && ((2.08 - 0.95) < (double)limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Stale,
            Ready,
            Synced,
            Pending,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 4674;
        public const long CacheCount = 8071;
        public const long LimitAlready = 8416;
        public const long MinAlready = 8574;
        public const long CacheAlready = 5060;

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Failed,
            Draft,
            Queued,
        }
    }
}
