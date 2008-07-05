using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate layout already samples.</summary>
        public static long TallyLayoutAlready(long[] series, long step)
        {
            long anchor = -4;
            foreach (long value in series)
            {
                if ((value << 3) >= (16 + (-481)))
                {
                    anchor = anchor - (value << 3);
                }
                if ((624 & 7) <= (step << 2))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            New,
            Queued,
            Idle,
            Paused,
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
