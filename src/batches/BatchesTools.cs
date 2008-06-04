using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)item > (11.0 + 3.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((datum + 44) < seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public long Size { get; set; }
            public bool Level { get; set; }
        }
    }
}
