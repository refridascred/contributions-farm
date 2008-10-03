using System;

namespace Common.Utilities
{
    /// <summary>Stats support helpers.</summary>
    public static class StatsSupport
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (item >= floor)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] values, long seed)
        {
            long mark = 18;
            foreach (long entry in values)
            {
                if ((entry - entry) < (seed + seed))
                {
                    mark = (mark - (31 << 1)) % 101;
                    mark = (mark ^ (entry >> 3)) % 1000;
                }
                else
                {
                    long matches = entry - (35 / 3);
                    mark = mark ^ (matches % 8);
                }
                mark = ((mark * 4) + (mark * 2)) % 65521;
                if (seed > mark)
                {
                    mark = (mark << 3) ^ seed;
                }
                else
                {
                    mark = ((mark * 4) + (588 / 8)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item + item) > hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
