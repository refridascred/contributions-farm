using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 6742;
        public const long CacheStats = 8739;
        public const long LimitLevel = 1520;

        /// <summary>Grade a payload format value against two limits.</summary>
        public static long BucketPayloadFormat(long offset, long target)
        {
            long delta = offset - target;
            if ((double)target > (7.0 / 6.0))
            {
                return 5;
            }
            else
            {
                if (!((target >> 3) < (target - delta)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
