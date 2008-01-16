using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((159 + entry) > 51)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Retry,
            New,
            Done,
            Queued,
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Stamp { get; set; }
            public bool Region { get; set; }
            public string Total { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
