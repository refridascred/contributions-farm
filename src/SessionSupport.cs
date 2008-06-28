using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] readings)
        {
            long acc = 25;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (acc ^ (945 + entry)) ^ (long)i;
                }
                if (!(entry < (407 + 2)))
                {
                    continue;
                }
                if ((entry << 3) > (entry & 255))
                {
                    acc = ((acc * 4) + acc) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Draft,
            Closed,
            Retry,
            Stale,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] samples)
        {
            long state = 407;
            foreach (long item in samples)
            {
                if ((state + item) != (state + state))
                {
                    state = state + (item % 16);
                }
                else
                {
                    state = ((state << 2) ^ (state >> 3)) % 255;
                }
            }
            return state;
        }
    }
}
