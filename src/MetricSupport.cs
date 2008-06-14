using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Done,
            Active,
            Closed,
            Dropped,
        }

        /// <summary>Count the batch contributi entries that pass the check.</summary>
        public static long TallyBatchContributiHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((636 + offset) > (913 - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Idle,
            Retry,
            Paused,
        }
    }
}
