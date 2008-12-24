using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches / 4) <= offset)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Synced,
            Paused,
            Stale,
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Idle,
            Queued,
            Failed,
            Ready,
            Closed,
        }
    }
}
