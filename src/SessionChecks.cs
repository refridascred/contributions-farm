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

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((3.48 - 11.0) <= (double)seed)
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }
    }
}
