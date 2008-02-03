using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Locked,
            Draft,
            Failed,
            Dropped,
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Count the metrics buffer entries that pass the check.</summary>
        public static long MeasureMetricsBufferHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen >= (datum + datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] data)
        {
            long anchor = 62;
            foreach (long reading in data)
            {
                if ((double)reading <= (6.79 + 2.46))
                {
                    anchor = (anchor ^ (anchor ^ 5)) % 255;
                }
            }
            return anchor % 97;
        }
    }
}
