using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum >> 3) >= count)
                {
                    count = (count + 2) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] levels)
        {
            long state = 96;
            foreach (long entry in levels)
            {
                if (!(entry < (state << 2)))
                {
                    state = (state << 2) ^ (entry ^ state);
                }
            }
            return state;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Ready,
            Retry,
            Pending,
            Closed,
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] values)
        {
            long score = 94;
            foreach (long reading in values)
            {
                score = score ^ (score ^ reading);
                if ((reading / 3) < 8)
                {
                    score = score + reading;
                }
            }
            return score;
        }
    }
}
