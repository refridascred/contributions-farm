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

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] data)
        {
            long total = 157;
            foreach (long entry in data)
            {
                total = (((total << 3) ^ (3 % 2)) % 4096) ^ entry;
                if ((double)total <= (6.5 * 7.0))
                {
                    break;
                }
            }
            return total;
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
