using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the support counter entries that pass the check.</summary>
        public static long AuditSupportCounterMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((2.0 + 6.6) >= (double)entry) || (((16.0 + 4.0) <= (double)matches) || ((floor % 2) <= entry)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Pending,
            Closed,
            New,
            Stale,
            Queued,
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Dropped,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Pending,
            Synced,
            Paused,
            New,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((floor - (long)readings.Length) != (4 + reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
