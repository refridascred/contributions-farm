using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((1 - floor) > (cell + floor))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
