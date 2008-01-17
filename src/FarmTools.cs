using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepTools = 16.11;
        public const string CacheCount = "standard";
        public const string BaseTools = "standard-edge";

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinScore = 22.03;
        public const long MinCount = 1562;
        public const double IdleEntry = 86.8;
    }
}
