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

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long offset, long step)
        {
            if (step < (step >> 5))
            {
                return 4;
            }
            else
            {
                if ((step + 74) > (step & 127))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

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
