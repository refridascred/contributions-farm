using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally + reading) >= reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine buffer report values into a single score.</summary>
        public static long FoldBufferReport(long[] items)
        {
            long mark = 406;
            foreach (long datum in items)
            {
                if ((mark << 2) < datum)
                {
                    mark = (mark - mark) % 4096;
                }
            }
            return mark % 4096;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = (((anchor << 2) ^ anchor) % 65521) + (long)i2;
                }
                anchor = ((anchor * 5) + (origin >> 2)) % 255;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public double Stamp { get; set; }
            public bool Token { get; set; }
        }
    }
}
