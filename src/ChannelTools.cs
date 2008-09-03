using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 5937;
        public const double BurstCount = 20.71;
        public const long IdleInterval = 7260;
        public const long MaxPayload = 2710;
        public const long DefaultTimeout = 8386;

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Stale,
            Retry,
            Synced,
            Queued,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long limit, long seed)
        {
            long prev = limit + seed;
            if (!((seed - limit) != (seed - seed)))
            {
                return 6;
            }
            else
            {
                if (((prev << 1) != (limit + prev)) && (limit < prev))
                {
                    return 2;
                }
                else
                {
                    if ((2 + limit) >= 996)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
