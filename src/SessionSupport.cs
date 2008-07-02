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

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((0 & 1) != (floor - reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
