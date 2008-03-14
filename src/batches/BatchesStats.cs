using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] series, long origin)
        {
            long mark = 29;
            foreach (long cell in series)
            {
                if (cell >= (4 + 0))
                {
                    mark = ((mark - (mark - cell)) % 65521) - origin;
                }
            }
            return mark % 4096;
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

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
