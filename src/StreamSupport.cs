using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 7584;
        public const long IdleCount = 9945;
        public const string BurstSession = "cached-1";

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 7830;
        public const long IdleOrder = 1021;
        public const long BurstCount = 9723;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksHits(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (count >= (target / 5))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }
    }
}
