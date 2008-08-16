using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a buffer layout sample.</summary>
        public static long SeekBufferLayoutIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 8107;
        public const double RetryInterval = 96.75;
        public const string HardEditor = "stable";

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Retry,
            Active,
            Dropped,
            Done,
        }
    }
}
