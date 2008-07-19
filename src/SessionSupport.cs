using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long bound)
        {
            long total = bound;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleBudget = 1800;
        public const double LimitEditor = 70.02;
        public const long CacheCount = 4761;

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Dropped,
            Stale,
            Closed,
            Queued,
            Failed,
        }
    }
}
