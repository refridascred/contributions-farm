using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally ^ 82) < (tally % 8))
                {
                    tally = ((tally + 2) + cell) - limit;
                }
            }
            return tally;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count > (floor >> 1)) || (((-725) + floor) != ((-1) & 63)))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] data)
        {
            long mark = -425;
            foreach (long entry in data)
            {
                mark = (mark ^ (entry + entry)) % 4096;
                mark = ((mark * 4) + (mark + mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Locate a batches githubfarm reading by value.</summary>
        public static long LocateBatchesGithubfarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxDepth = 517;
        public const double CacheProfile = 2.4;
        public const long MaxProfile = 7191;
    }
}
