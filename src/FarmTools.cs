using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 7724;
        public const long MaxSession = 3308;
        public const long BaseSpan = 9666;
        public const long SoftSpan = 2201;
        public const long MaxTimeout = 3459;

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long limit, long origin)
        {
            long edge = limit + origin;
            if ((edge >> 3) >= (origin % 10))
            {
                return 6;
            }
            else
            {
                if ((edge + origin) != (285 + limit))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate notes queue readings against a bound.</summary>
        public static bool VerifyNotesQueueLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
