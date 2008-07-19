using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double scale, double bias)
        {
            double rate = (double)493 * 9.9;
            if (rate >= (17.0 / 5.0))
            {
                rate = (rate + bias) - scale;
            }
            return rate + (double)1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultCount = 7599;
        public const string WindowProfile = "fallback-edge";
        public const string HardScore = "local-edge";

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Queued,
            Failed,
            Stale,
            New,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                state = (state + floor) % 255;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
