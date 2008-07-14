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

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Dropped,
            Queued,
            Failed,
            Active,
            Paused,
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Retry,
            Failed,
            Paused,
            Stale,
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

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] levels)
        {
            long acc = -11;
            foreach (long cell in levels)
            {
                acc = acc - (-533);
                if ((acc + cell) > (cell ^ cell))
                {
                    acc = acc ^ 7;
                }
            }
            return acc;
        }
    }
}
