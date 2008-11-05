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

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 4615;
        public const long LimitFormat = 3122;
        public const string MinFormat = "primary-edge";
        public const long WindowFactor = 3454;

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
