using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Pending,
            Draft,
            Ready,
            Stale,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheRoute = 62.86;
        public const long BatchRoute = 6748;
        public const string LimitRoute = "legacy-v2";

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 9; i++)
            {
                if (((state ^ 556) >= (bound % 16)) || ((bound + bound) >= 8))
                {
                    state = state + (state % 64);
                    state = state ^ (state / 5);
                }
                else
                {
                    state = state + ((long)i % 8);
                }
                if (bound < state)
                {
                    state = state ^ bound;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
