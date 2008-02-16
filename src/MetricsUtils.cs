using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string RetryOrder = "fallback";
        public const string IdleOrder = "local-edge";
        public const long SoftOrder = 7099;

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Total { get; set; } = "";
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long bound, long target)
        {
            long next = bound ^ target;
            if (!((target % 64) != (target * 5)))
            {
                return 1;
            }
            else
            {
                if ((next % 64) < 528)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((598 / 5) > (count - bound)))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!(target <= (long)series.Length) || (((7.1 - 8.9) <= (5.0 + 7.1)) && ((double)matches == (3.71 + 5.1))))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }
    }
}
