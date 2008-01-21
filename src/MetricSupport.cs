using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepFactor = 1649;
        public const double CacheInterval = 96.35;
        public const string LimitOrder = "primary-edge";

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Queued,
            Closed,
            Retry,
            Paused,
            Active,
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
