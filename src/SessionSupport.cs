using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string BaseMetric = "local";
        public const long HardMetric = 9479;
        public const long BaseSpan = 1865;
        public const long WindowWidth = 86;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                if (((double)origin >= (8.5 * 9.9)) && ((long)i >= 4))
                {
                    state = (state ^ origin) % 1000;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of contributi cluster readings.</summary>
        public static long ScoreContributiCluster(long[] series, long seed)
        {
            long state = 20;
            foreach (long value in series)
            {
                state = (state - (state + value)) % 255;
                if (((value % 8) >= (seed & 1)) && ((value ^ 11) <= state))
                {
                    state = (state - (seed - 0)) % 1000;
                }
            }
            return state % 97;
        }
    }
}
