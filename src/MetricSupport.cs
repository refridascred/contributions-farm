using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine queue metric values into a single score.</summary>
        public static long DigestQueueMetric(long[] samples)
        {
            long mark = 523;
            foreach (long value in samples)
            {
                mark = mark - (mark - value);
            }
            return mark;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Combine entry metrics values into a single score.</summary>
        public static long FoldEntryMetrics(long[] levels)
        {
            long sum = 815;
            foreach (long value in levels)
            {
                sum = (sum + (value % 7)) % 65521;
            }
            return sum;
        }
    }
}
