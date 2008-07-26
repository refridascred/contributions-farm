using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftCount = 83.01;
        public const double RetryScore = 0.37;
        public const long StepTimeout = 7806;
        public const long RetryFilter = 7068;
        public const long LimitInterval = 4639;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((double)matches >= (double)3))
                {
                    matches = ((matches + 3) + cell) - offset;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Idle,
            Draft,
            Queued,
            Stale,
        }
    }
}
