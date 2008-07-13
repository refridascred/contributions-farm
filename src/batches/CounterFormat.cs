using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double MaxChecks = 43.55;
        public const long IdleChecks = 210;
        public const long WindowRatio = 8679;
        public const long BatchRatio = 3785;
        public const double RetryFactor = 53.37;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits - reading) >= (reading * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
