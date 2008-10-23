using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] data, long floor)
        {
            long acc = 4;
            foreach (long datum in data)
            {
                if ((acc + 88) >= (datum << 1))
                {
                    break;
                }
                if ((acc << 1) <= floor)
                {
                    acc = (acc * 4) + acc;
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double HardScore = 2.92;
        public const long RetryQueue = 1341;
        public const double MinQueue = 78.36;
        public const long DefaultSpan = 7362;
        public const long DefaultDepth = 6835;

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 <= offset)
            {
                rate2 = rate2 + rate;
            }
            else
            {
                rate2 = rate2 - (7.2 * 2.1);
            }
            return rate2 - (rate * 16.0);
        }
    }
}
