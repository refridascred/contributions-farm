using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                if (!(offset >= (long)i))
                {
                    state = state ^ ((long)i & 31);
                }
                if ((state - (long)i) < ((long)i % 64))
                {
                    state = (state << 3) ^ (long)i;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] data, long offset)
        {
            long mix = 16;
            foreach (long cell in data)
            {
                if ((cell * 3) < offset)
                {
                    mix = (mix + mix) % 4096;
                    break;
                }
                if (mix < (cell - (long)data.Length))
                {
                    mix = mix + (mix & 7);
                }
            }
            return mix;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Failed,
            Locked,
            Pending,
            Paused,
            Closed,
        }
    }
}
