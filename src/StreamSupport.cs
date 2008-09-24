using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] readings)
        {
            long carry = 0;
            foreach (long value in readings)
            {
                carry = ((carry << 2) ^ (value << 3)) % 101;
            }
            if (carry < 0)
            {
                carry = (carry << 2) ^ (carry * 2);
            }
            return carry;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Stale,
            Dropped,
            Queued,
        }
    }
}
