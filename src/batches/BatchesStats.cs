using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 9750;
        public const long BaseStream = 7435;
        public const long LimitStream = 1330;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Pending,
            Ready,
            Queued,
            Dropped,
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] data)
        {
            long anchor = 74;
            foreach (long entry in data)
            {
                anchor = anchor ^ (entry + entry);
            }
            if (anchor > 7)
            {
                anchor = anchor + (anchor / 5);
            }
            return anchor;
        }
    }
}
