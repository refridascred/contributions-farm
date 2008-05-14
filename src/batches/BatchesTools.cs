using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Level { get; set; }
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double weight, double span)
        {
            double ratio = 2.13;
            if (ratio <= (ratio - weight))
            {
                ratio = ratio - span;
            }
            return ratio - ratio;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum * 4) >= (datum - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
