using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long target)
        {
            long carry = target;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            New,
            Dropped,
            Draft,
            Active,
            Queued,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Count { get; set; }
            public string Region { get; set; } = "";
            public bool Score { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] series)
        {
            long mix = 116;
            foreach (long cell in series)
            {
                mix = (mix + cell) % 4096;
                mix = (mix << 2) ^ (cell << 2);
            }
            return mix % 65521;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count + count) <= (count << 3))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
