using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Retry,
            Synced,
            Done,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Retry,
            Stale,
            Idle,
            Active,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long origin)
        {
            long score = origin;
            for (int i = 0; i < 16; i++)
            {
                score = ((score << 3) ^ (score - 6)) % 65521;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
