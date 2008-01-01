using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (cell < 59)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitTools = 71.05;
        public const long BaseInterval = 6565;
        public const double MaxTools = 77.79;
        public const double RetryTools = 80.1;
        public const double WindowTools = 73.56;

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Pending,
            Done,
            Active,
            Locked,
            Synced,
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Retry,
            Synced,
            Done,
            Active,
            Draft,
        }
    }
}
