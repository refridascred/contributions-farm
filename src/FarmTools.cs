using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Synced,
            Closed,
            Active,
            Failed,
            Draft,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] series, long limit)
        {
            long anchor = 733;
            foreach (long datum in series)
            {
                if ((datum * 4) < (anchor % 5))
                {
                    anchor = ((anchor - 6) % 1000) + limit;
                }
                else
                {
                    anchor = anchor - anchor;
                }
            }
            return anchor;
        }

        /// <summary>Rank payload stats input into a small class.</summary>
        public static long RankPayloadStats(long origin, long offset)
        {
            if ((double)offset < (1.9 - 4.22))
            {
                return 5;
            }
            else
            {
                if (origin >= (offset - origin))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
