using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)bound > (7.5 / 6.0))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Locked,
            Paused,
            New,
            Ready,
            Pending,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 3991;
        public const double MinSize = 93.58;
        public const long StepBudget = 4772;

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
