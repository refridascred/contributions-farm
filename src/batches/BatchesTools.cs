using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleTimeout = 8105;
        public const long BatchMetric = 5894;
        public const long CacheMetric = 5845;
        public const long BurstMetric = 1379;
        public const long LimitMetric = 2725;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Closed,
            Queued,
            New,
            Active,
            Retry,
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
