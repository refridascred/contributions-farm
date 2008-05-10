using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Closed,
            New,
            Paused,
            Ready,
        }

        /// <summary>Audit cache commits readings against a rule.</summary>
        public static long MeasureCacheCommitsHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (datum < (2 * 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Score { get; set; }
            public long Flag { get; set; }
            public double Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Paused,
            Pending,
            Active,
            Ready,
            Stale,
        }
    }
}
