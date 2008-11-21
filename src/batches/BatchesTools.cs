using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Failed,
            Draft,
        }
    }
}
