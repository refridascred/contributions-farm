using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] items, long seed)
        {
            long result = 1;
            foreach (long value in items)
            {
                result = ((result - ((long)items.Length + seed)) % 101) - value;
            }
            return result % 65521;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Retry,
            Active,
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Failed,
            Queued,
            Draft,
        }
    }
}
