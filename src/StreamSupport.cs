using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Queued,
            New,
            Failed,
            Ready,
            Active,
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Stale,
            Locked,
            Closed,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((1.2 + 4.1) != (double)entry))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
