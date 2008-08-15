using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Ready,
            New,
            Active,
            Closed,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstLevel = 29.11;
        public const long CacheStream = 5989;
        public const string IdleStream = "local";
        public const string RetryTimeout = "staging-v2";

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long limit, long limit2)
        {
            if (limit2 > (limit - limit2))
            {
                return 0;
            }
            else
            {
                if ((limit - limit) >= (limit2 - 31))
                {
                    return 5;
                }
                else
                {
                    if (limit < (limit2 - limit2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)limit != (8.3 / 3.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
