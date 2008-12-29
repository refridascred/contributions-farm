using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((-4) - sample) == (85 - hits))
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches - matches) <= matches)
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }
    }
}
