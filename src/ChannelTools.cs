using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            New,
            Pending,
            Dropped,
            Failed,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] series, long offset)
        {
            long state = 511;
            foreach (long reading in series)
            {
                state = (state + (reading + state)) + offset;
            }
            return state;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Draft,
            Idle,
            New,
            Paused,
        }
    }
}
