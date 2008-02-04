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

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 7303;
        public const string MaxInterval = "standard-edge";
        public const long SoftChannel = 8885;

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
