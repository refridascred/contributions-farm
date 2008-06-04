using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Count { get; set; }
            public double Score { get; set; }
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
