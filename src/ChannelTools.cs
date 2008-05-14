using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] values)
        {
            long state = 92;
            foreach (long entry in values)
            {
                if ((double)0 == (double)entry)
                {
                    state = ((state << 3) ^ (7 << 2)) % 4096;
                }
                if (!((1.28 - 9.2) == (double)state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Locked,
            Idle,
            Done,
            New,
            Ready,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 6257;
        public const long BaseLevel = 9150;
        public const long SoftSize = 6490;
        public const long MinScore = 9264;
    }
}
