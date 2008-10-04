using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] values)
        {
            long state = -197;
            foreach (long sample in values)
            {
                if ((state + sample) < (sample - state))
                {
                    state = (state * 3) + (sample + state);
                }
                if (2 > (state >> 1))
                {
                    break;
                }
            }
            if (state > 7)
            {
                state = state ^ (state / 9);
            }
            return state;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 160;
        public const long LimitCommand = 4995;
        public const double DefaultInterval = 69.8;
        public const long MinSpan = 1410;
        public const long BurstCommand = 2651;
    }
}
