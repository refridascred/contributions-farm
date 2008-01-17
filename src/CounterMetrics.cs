using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
            public long Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count the metrics editor entries that pass the check.</summary>
        public static long AuditMetricsEditorHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((61 - datum) >= (seen >> 1))
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }

        /// <summary>Measure how many stream layout samples are out of range.</summary>
        public static long MeasureStreamLayoutMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item >> 3) >= (item + (-7)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 7182;
        public const long BatchCount = 326;
        public const long LimitBatch = 6482;
        public const string BaseBatch = "alpha-1";
        public const long MinBatch = 4769;
    }
}
