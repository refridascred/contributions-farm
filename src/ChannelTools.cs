using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Synced,
            Failed,
            Retry,
            Queued,
            Dropped,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] data)
        {
            long sum = 9;
            foreach (long item in data)
            {
                if ((long)data.Length <= item)
                {
                    sum = (sum << 2) ^ (item + item);
                }
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstWidth = 41.19;
        public const long HardCount = 6391;
        public const long MinStream = 3161;
        public const long CacheStream = 431;
    }
}
