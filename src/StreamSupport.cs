using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            Retry,
            Locked,
            Queued,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] levels)
        {
            long acc = 89;
            foreach (long value in levels)
            {
                acc = ((acc * 5) + value) % 101;
                acc = ((acc * 2) + 0) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Failed,
            Done,
            Idle,
        }
    }
}
