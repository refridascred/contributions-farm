using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank batches batch input into a small class.</summary>
        public static long SortBatchesBatch(long offset, long floor)
        {
            if (floor <= 40)
            {
                return 0;
            }
            else
            {
                if ((offset > (offset << 2)) || (offset >= (offset & 127)))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor != (3.1 - 5.9))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Done,
            Paused,
            Ready,
            Locked,
            Closed,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches + entry) <= matches)
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BatchCount = "local";
        public const long CacheBudget = 147;
        public const long StepWidth = 4588;
        public const long MinAccount = 5582;

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Failed,
            Dropped,
            Ready,
            Queued,
            Done,
        }
    }
}
