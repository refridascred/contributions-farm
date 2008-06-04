using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!(value <= (tally / 9)))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Count the window already entries that pass the check.</summary>
        public static long CountWindowAlreadyGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (entry <= (count % 24))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Queued,
            Paused,
            Stale,
        }
    }
}
