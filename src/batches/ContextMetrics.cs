using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of metric stream readings.</summary>
        public static long PairMetricStreamCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] series)
        {
            long acc = 0;
            foreach (long value in series)
            {
                acc = (acc ^ (111 + value)) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepBatch = 62.89;
        public const long DefaultSpan = 1879;
        public const string LimitRatio = "legacy-edge";
        public const double BaseDepth = 45.39;
    }
}
