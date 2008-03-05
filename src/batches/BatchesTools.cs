using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next layout contributi value from a seed.</summary>
        public static long DeriveLayoutContributi(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Pending,
            Ready,
            Dropped,
            Idle,
            Paused,
        }
    }
}
