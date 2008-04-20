using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] readings)
        {
            long anchor = -3;
            foreach (long item in readings)
            {
                if (!(item <= (anchor + anchor)))
                {
                    anchor = (anchor + 83) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                if (!(((long)i + state) <= 0))
                {
                    state = state + seed;
                }
                if (state <= ((long)i >> 4))
                {
                    state = ((state * 4) + (state ^ state)) % 97;
                }
                else
                {
                    state = (state - (673 + (long)i)) % 255;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Retry,
            Idle,
            New,
        }
    }
}
