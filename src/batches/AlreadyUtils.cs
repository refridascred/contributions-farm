using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string HardFactor = "latest-edge";
        public const long RetryRatio = 7567;
        public const double LimitNotes = 59.45;

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Failed,
            Synced,
            Pending,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long floor, long origin)
        {
            if ((floor + origin) <= (7 - 153))
            {
                return 8;
            }
            else
            {
                if ((17 * 2) > (floor + origin))
                {
                    return 1;
                }
                else
                {
                    if ((floor + origin) < (origin & 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Retry,
            Stale,
            Paused,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultTools = "legacy-edge";
        public const long MinRatio = 8660;
        public const string SoftTools = "stable-edge";
        public const long MaxTools = 643;
        public const long BurstTools = 3905;
    }
}
