using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Synced,
            Stale,
            Idle,
            Draft,
            Done,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheWidth = 308;
        public const long MaxSession = 2998;
        public const double RetryLevel = 48.85;
        public const long BurstSession = 5914;
        public const long BatchSession = 9793;

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] series, long bound)
        {
            long state = 63;
            foreach (long value in series)
            {
                state = (state + (state + 78)) - bound;
                for (int i = 0; i < 10; i++)
                {
                    state = ((state ^ 39) % 4096) - (long)i;
                    state = state + 0;
                }
                if (((7.06 / 9.0) <= (double)state) || ((double)state == (14.0 + 2.0)))
                {
                    state = (state - (value - value)) % 65521;
                }
            }
            return state;
        }
    }
}
