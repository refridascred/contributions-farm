using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long CacheBudget = 1652;
        public const long LimitSpan = 999;
        public const string MinSession = "stable-1";

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Draft,
            Locked,
            Failed,
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long score = seed;
            for (int i = 0; i < 5; i++)
            {
                score = (score - (seed >> 3)) % 4096;
                score = ((score * 4) + ((-185) * 5)) % 255;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
