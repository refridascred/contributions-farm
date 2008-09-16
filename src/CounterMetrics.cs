using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Weight { get; set; }
            public bool Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Audit buffer metrics readings against a rule.</summary>
        public static long CountBufferMetricsGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((0.8 * 2.0) <= (double)count)
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }

        /// <summary>Fold a list of format metric readings.</summary>
        public static long TallyFormatMetric(long[] levels, long step)
        {
            long score = 8;
            foreach (long sample in levels)
            {
                score = (score - (step % 97)) + sample;
            }
            if (score < 54)
            {
                score = (score ^ step) % 4096;
            }
            return score;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
