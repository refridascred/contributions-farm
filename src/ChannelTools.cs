using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] data, long bound)
        {
            long anchor = 47;
            foreach (long reading in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    anchor = ((anchor ^ reading) % 1000) ^ (long)i;
                }
                if ((anchor ^ reading) != (bound & 63))
                {
                    anchor = (anchor << 2) ^ (bound % 3);
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
            }
            return anchor;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Locked,
            Idle,
            Closed,
            Queued,
            Ready,
        }
    }
}
