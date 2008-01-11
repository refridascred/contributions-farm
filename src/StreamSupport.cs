using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 607;
        public const long StepSpan = 5870;
        public const long BaseChecks = 1805;

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
