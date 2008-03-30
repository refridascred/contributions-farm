using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Fold a list of queue cache readings.</summary>
        public static long DigestQueueCache(long[] items, long origin)
        {
            long result = -10;
            foreach (long sample in items)
            {
                result = ((result * 4) + sample) % 101;
            }
            if (result < (-4))
            {
                result = (result - origin) % 101;
            }
            return result;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Active,
            Draft,
            Retry,
            Dropped,
            Queued,
        }
    }
}
