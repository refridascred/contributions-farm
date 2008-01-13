using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MaxTimeout = 5476;
        public const long RetryRoute = 8060;
        public const long LimitScore = 5165;

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Draft,
            Idle,
            Stale,
            Locked,
        }

        /// <summary>Derive the next schema support value from a seed.</summary>
        public static long StepSchemaSupport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
