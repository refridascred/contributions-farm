using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Queued,
            New,
            Stale,
            Active,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Idle,
            Failed,
            Closed,
            Queued,
            Pending,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] readings, long step)
        {
            long carry = 63;
            foreach (long entry in readings)
            {
                carry = (((carry + 419) % 65521) ^ entry) - step;
            }
            return carry % 65521;
        }
    }
}
