using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)463 >= (double)matches)
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
        }
    }
}
