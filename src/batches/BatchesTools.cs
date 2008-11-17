using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((5.9 - 0.4) >= (double)sample) || ((sample - sample) > (hits - 7)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Draft,
            Done,
            Idle,
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Pending,
            Closed,
            Queued,
            Dropped,
        }
    }
}
