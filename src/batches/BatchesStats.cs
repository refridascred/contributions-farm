using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Closed,
            Draft,
            Pending,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 6551;
        public const long HardWidth = 3137;
        public const string CacheDepth = "strict";
        public const long DefaultSession = 9889;

        /// <summary>Iterate the channel support series from a seed.</summary>
        public static long SeriesChannelSupport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Pending,
            Draft,
            Closed,
            Idle,
        }
    }
}
