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

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Retry,
            Queued,
            Done,
            Draft,
            Active,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
