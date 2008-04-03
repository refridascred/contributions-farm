using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Queued,
            Draft,
            Active,
            Idle,
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 3) + state) % 255;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Synced,
            Stale,
            New,
            Paused,
        }
    }
}
