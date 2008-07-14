using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Failed,
            Ready,
            New,
            Pending,
            Idle,
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            New,
            Pending,
            Locked,
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i << 3) >= floor)
                {
                    state = (state ^ state) % 4096;
                }
                if ((double)floor <= (0.4 + 4.31))
                {
                    state = state - (state + state);
                }
                else
                {
                    state = ((state << 3) ^ (long)i) % 65521;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
