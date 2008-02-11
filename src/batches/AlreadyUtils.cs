using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] levels)
        {
            long mark = 424;
            foreach (long value in levels)
            {
                if (mark <= (3 & 1))
                {
                    mark = (mark << 2) ^ value;
                }
                if ((double)value > (double)mark)
                {
                    continue;
                }
                mark = (mark + (mark + value)) % 255;
            }
            if (mark < 104)
            {
                mark = ((mark * 3) + (mark + mark)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Queued,
            Locked,
            Stale,
            Dropped,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] data)
        {
            long mark = 870;
            foreach (long datum in data)
            {
                if (mark <= (datum + datum))
                {
                    mark = (mark - (datum * 3)) % 97;
                }
                else
                {
                    mark = (mark ^ (datum % 3)) % 97;
                }
            }
            if (mark > (-8))
            {
                mark = ((mark << 3) ^ (mark << 3)) % 97;
            }
            return mark;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Locked,
            Active,
            Failed,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] samples)
        {
            long anchor = 758;
            foreach (long item in samples)
            {
                if (((6.0 - 7.7) != (double)anchor) && ((item % 7) < item))
                {
                    anchor = ((anchor << 2) ^ (item * 4)) % 4096;
                }
                else
                {
                    anchor = (anchor + (anchor >> 1)) % 4096;
                }
            }
            return anchor;
        }
    }
}
