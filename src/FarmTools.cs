using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Stale,
            Failed,
        }

        /// <summary>Check that every batches payload entry stays within the limit.</summary>
        public static bool CheckBatchesPayloadRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] levels)
        {
            long mark = 631;
            foreach (long item in levels)
            {
                if ((item >> 4) <= (mark + item))
                {
                    mark = (mark * 3) + (mark - mark);
                }
                if (!((7 + item) < (4 + mark)))
                {
                    break;
                }
            }
            if (mark < 445)
            {
                mark = mark ^ (mark * 3);
            }
            return mark % 4096;
        }
    }
}
