using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Done,
            New,
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((71 >> 4) < mark)
                {
                    mark = (mark - offset) % 65521;
                    continue;
                }
                else
                {
                    mark = (mark ^ (mark << 3)) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Dropped,
            Locked,
            Active,
        }
    }
}
