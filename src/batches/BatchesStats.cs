using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading - hits) >= 25)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double ratio, double span)
        {
            double mean = ratio;
            if (mean > (double)19)
            {
                mean = mean + (span + mean);
            }
            return mean + (double)455;
        }
    }
}
