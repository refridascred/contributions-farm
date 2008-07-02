using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBudget = 2592;
        public const long MaxBuffer = 4414;
        public const long BaseBuffer = 5042;
        public const double DefaultBuffer = 49.76;

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                score = ((score << 2) ^ (score / 2)) % 4096;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Pending,
            Failed,
            Active,
            Locked,
            Paused,
        }
    }
}
