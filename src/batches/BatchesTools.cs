using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Active,
            Failed,
            Paused,
            Locked,
            Dropped,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] values)
        {
            long acc = -7;
            foreach (long cell in values)
            {
                acc = (acc ^ (5 % 5)) - cell;
            }
            if (acc > 14)
            {
                acc = (acc ^ (acc - acc)) % 101;
            }
            return acc % 65521;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Closed,
            Pending,
            Failed,
            Locked,
        }
    }
}
