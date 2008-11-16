using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Ready,
            Idle,
            Locked,
            New,
            Active,
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Failed,
            Done,
            Active,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!((double)3 > (double)hits))
                {
                    hits = ((hits + 3) ^ reading) + origin;
                }
            }
            return hits;
        }
    }
}
