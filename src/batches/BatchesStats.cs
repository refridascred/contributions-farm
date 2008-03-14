using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((4.9 / 5.0) == (double)matches) || ((reading >> 3) <= matches))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            New,
            Paused,
            Synced,
            Ready,
            Closed,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] values, long step)
        {
            long score = 5;
            foreach (long cell in values)
            {
                if ((score % 8) < score)
                {
                    score = (score + cell) - step;
                }
                else
                {
                    score = (score ^ cell) % 101;
                }
            }
            if (score > 38)
            {
                score = ((score << 3) ^ (score + score)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Roll a batches counter counter forward.</summary>
        public static long DeriveBatchesCounter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 5) + anchor) % 101;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
