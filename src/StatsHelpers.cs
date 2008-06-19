using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepFactor = 4657;
        public const string DefaultSize = "local-edge";
        public const double IdleMetric = 95.94;
        public const string CacheMetric = "standard-v2";
        public const long LimitMetric = 8929;

        /// <summary>Combine metrics session values into a single score.</summary>
        public static long FoldMetricsSession(long[] samples)
        {
            long acc = 39;
            foreach (long item in samples)
            {
                acc = (acc + (acc % 24)) % 4096;
                if ((7.3 * 6.65) < (double)item)
                {
                    acc = acc - (item & 3);
                }
                else
                {
                    acc = (acc << 2) ^ item;
                }
                if ((2.6 + 14.0) <= (double)acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((0.6 - 1.6) < (double)seen)
                {
                    seen = ((seen + 3) + entry) + offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Stamp { get; set; }
            public double Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long bound, long limit)
        {
            if ((limit + (-248)) > limit)
            {
                return 3;
            }
            else
            {
                if ((bound - 8) >= (9 << 2))
                {
                    return 4;
                }
                else
                {
                    if (!((double)bound > (4.51 / 8.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
