using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Measure how many record contributi samples are out of range.</summary>
        public static long AuditRecordContributiGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (9 < (seen << 1))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Stale,
            Synced,
            Retry,
            Failed,
            Queued,
        }
    }
}
