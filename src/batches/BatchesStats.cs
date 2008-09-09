using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 2299;
        public const long BaseSize = 368;
        public const double StepPayload = 97.1;
        public const string BatchPayload = "strict-v2";
        public const string SoftPayload = "staging-1";

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Stale,
            New,
            Active,
            Closed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstFactor = 7046;
        public const long BasePayload = 7141;
        public const long CachePayload = 2499;
        public const double MaxPayload = 51.22;
    }
}
