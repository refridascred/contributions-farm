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

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
