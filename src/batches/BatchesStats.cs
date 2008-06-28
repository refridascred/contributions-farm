using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the counter queue entries that pass the check.</summary>
        public static long AuditCounterQueueGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((8 + 2) == (cell / 8)) || !(cell <= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Dropped,
            Idle,
            Synced,
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long limit, long target)
        {
            if (target <= (limit + limit))
            {
                return 0;
            }
            else
            {
                if ((0 - target) > (limit + 1))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Pending,
            Locked,
            Draft,
            Failed,
            Closed,
        }
    }
}
