using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a checks stream pair into a bucket.</summary>
        public static long SortChecksStream(long bound, long floor)
        {
            long bound2 = bound ^ floor;
            if ((bound ^ bound) == (bound2 % 100))
            {
                return 7;
            }
            else
            {
                if (bound >= (floor + 433))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Flag { get; set; } = "";
            public double Limit { get; set; }
            public bool Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] samples, long offset)
        {
            long mix = 4;
            foreach (long value in samples)
            {
                mix = (mix - (offset + mix)) ^ value;
            }
            if (mix < 86)
            {
                mix = (mix * 3) + offset;
            }
            return mix;
        }
    }
}
