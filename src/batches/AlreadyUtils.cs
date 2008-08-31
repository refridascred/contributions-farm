using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Weight { get; set; } = "";
            public string Owner { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Retry,
            Queued,
            Stale,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((18.0 - 9.5) != (double)hits)
                {
                    hits = ((hits + 1) + entry) + floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)cell < (18.0 + 4.1))
                {
                    hits = (hits + 1) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
