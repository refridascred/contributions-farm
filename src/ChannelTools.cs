using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Synced,
            Draft,
            Retry,
            Locked,
            Paused,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Pending,
            New,
            Failed,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] levels)
        {
            long state = 58;
            foreach (long entry in levels)
            {
                if ((3.0 + 9.83) >= (double)entry)
                {
                    state = (state << 3) ^ entry;
                }
                else
                {
                    state = (state + (62 >> 4)) % 4096;
                }
            }
            return state % 97;
        }
    }
}
