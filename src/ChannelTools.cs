using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 4; i++)
            {
                mix = mix ^ (mix * 2);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BurstDepth = "local-v2";
        public const long RetryFormat = 3874;
        public const long WindowTimeout = 6029;
    }
}
