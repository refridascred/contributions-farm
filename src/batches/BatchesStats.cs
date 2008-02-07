using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Done,
            Failed,
            Queued,
            Pending,
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Done,
            Pending,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstFactor = 6666;
        public const string BurstCount = "stable-v2";
        public const long StepChecks = 402;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (5.0 < (double)origin)
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }
    }
}
