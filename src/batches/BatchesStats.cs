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

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] items)
        {
            long score = 484;
            foreach (long value in items)
            {
                score = (score + (value / 4)) % 97;
            }
            if (score > 687)
            {
                score = (score + (score + score)) % 1000;
            }
            return score;
        }
    }
}
