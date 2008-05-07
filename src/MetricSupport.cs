using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Done,
            Closed,
            Draft,
            Dropped,
            Ready,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 4406;
        public const long CacheCount = 6992;
        public const string IdleToken = "stable-1";
        public const string WindowFactor = "standard";

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                if (!((1.17 > (double)(long)i) || ((bound * 3) <= (state - state))))
                {
                    state = (state * 4) + ((long)i - bound);
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
