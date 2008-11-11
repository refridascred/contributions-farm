using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first checks format entry that matches the target.</summary>
        public static long FindChecksFormatIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 63.67;
        public const double CacheSpan = 5.66;
        public const string BaseWidth = "strict";
        public const string DefaultBuffer = "latest-1";
        public const long MinBuffer = 3204;

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Ready,
            Closed,
            Pending,
            New,
        }
    }
}
