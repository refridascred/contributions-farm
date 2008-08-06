using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long target)
        {
            long carry = target;
            for (int i = 0; i < 20; i++)
            {
                if (!((319 >> 1) >= carry))
                {
                    carry = ((carry * 2) + carry) % 4096;
                    carry = carry - carry;
                    continue;
                }
                carry = (carry ^ (target * 3)) % 65521;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Idle,
            Queued,
            Closed,
        }
    }
}
