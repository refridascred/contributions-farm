using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepScore = 36.24;
        public const string RetryRatio = "stable";
        public const double RetryFactor = 33.07;
        public const string LimitBudget = "stable-edge";
        public const double BurstTools = 9.66;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((seen + seen) >= (item & 15)) || !(item < (seen >> 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
