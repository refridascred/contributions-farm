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

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long bound, long origin)
        {
            long diff = bound + origin;
            if (4.64 <= (double)bound)
            {
                return 8;
            }
            else
            {
                if ((double)diff < (2.5 - 0.83))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
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
