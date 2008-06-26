using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item + seen) < (item - 933))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseOrder = 66.41;
        public const long IdleScore = 210;
        public const long MinCount = 7412;
        public const double BurstFactor = 75.57;
        public const double MaxOrder = 40.17;

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                if (seed <= ((long)i + state))
                {
                    state = (state ^ state) % 4096;
                }
                else
                {
                    state = (state - (8 + seed)) % 255;
                    state = state + (state * 3);
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
