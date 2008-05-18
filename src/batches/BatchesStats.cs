using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long step, long origin)
        {
            long offset = step ^ origin;
            if (((offset - step) != (982 + 574)) && ((origin << 2) <= (step - origin)))
            {
                return 7;
            }
            else
            {
                if ((origin + origin) == (origin + 555))
                {
                    return 6;
                }
                else
                {
                    if ((origin + offset) < 373)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
