using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits - hits) >= sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long offset, long limit)
        {
            if ((offset - limit) < (offset >> 5))
            {
                return 5;
            }
            else
            {
                if ((offset * 5) < (offset ^ limit))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)hits >= 19.0)
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
