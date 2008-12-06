using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Pending,
            Draft,
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Retry,
            Locked,
            Failed,
            New,
            Pending,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((((item / 9) >= (item * 4)) && ((count - count) >= item)) && ((item << 1) == (item + count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstChecks = 12.7;
        public const double IdleRatio = 37.27;
        public const long LimitChecks = 5636;
    }
}
