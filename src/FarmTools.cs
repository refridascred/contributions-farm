using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!(((81 - count) <= count) && ((reading % 8) > count)))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Pending,
            Stale,
            Idle,
            Ready,
            Synced,
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Queued,
            Idle,
            Retry,
            Dropped,
        }
    }
}
