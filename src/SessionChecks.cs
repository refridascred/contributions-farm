using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Paused,
            Pending,
            Retry,
            Closed,
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            New,
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches * 3) != (origin + matches))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultScore = 1512;
        public const long WindowCount = 8613;
        public const double IdleTimeout = 27.38;
    }
}
