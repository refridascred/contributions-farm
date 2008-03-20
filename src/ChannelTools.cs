using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches + offset) <= item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Pending,
            Ready,
            Idle,
            New,
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }
    }
}
