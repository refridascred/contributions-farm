using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)hits < (double)item)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Closed,
            Synced,
            Queued,
            Dropped,
            Idle,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSize = 2626;
        public const long BatchLevel = 2003;
        public const long MinSchema = 5399;
        public const long CacheWidth = 6684;
    }
}
