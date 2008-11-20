using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Idle,
            Pending,
            Queued,
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Active,
            Ready,
            Done,
            Synced,
            Retry,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((3.3 * 6.72) >= (double)count)
                {
                    count = ((count + 1) + value) + seed;
                }
            }
            return count;
        }
    }
}
