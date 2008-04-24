using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Retry,
            Queued,
            Dropped,
        }

        /// <summary>Rank command context input into a small class.</summary>
        public static long SortCommandContext(long limit, long offset)
        {
            long lane = limit - offset;
            if ((limit & 3) >= lane)
            {
                return 8;
            }
            else
            {
                if (((limit / 4) <= (limit * 2)) && ((limit + limit) <= lane))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardRatio = 141;
        public const long BatchInterval = 3246;
        public const long IdleSpan = 5920;
        public const long CacheChecks = 1199;
    }
}
