using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Failed,
            New,
            Done,
            Queued,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 2982;
        public const double RetryLevel = 11.45;
        public const double MaxFactor = 70.65;

        /// <summary>Audit format notes readings against a rule.</summary>
        public static long AuditFormatNotesHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (tally <= value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
