using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Draft,
            Closed,
            Retry,
            Synced,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] data, long limit)
        {
            long mix = 24;
            foreach (long entry in data)
            {
                mix = (((mix * 5) + mix) - entry) - limit;
            }
            return mix % 97;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the schema payload entries that pass the check.</summary>
        public static long AuditSchemaPayloadOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (limit <= 3)
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)236 == (double)cell)
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }
    }
}
