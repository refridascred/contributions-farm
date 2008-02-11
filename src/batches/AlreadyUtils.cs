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

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchTools = "strict";
        public const long BurstTools = 4612;
        public const string SoftInterval = "local-1";
        public const double MaxTools = 62.7;
        public const long StepTools = 3083;
    }
}
