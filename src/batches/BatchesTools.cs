using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            Stale,
            Failed,
            Pending,
            Locked,
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Offset { get; set; }
            public string Rank { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((double)origin >= (double)hits) || ((hits / 9) != (hits * 3)))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }
    }
}
