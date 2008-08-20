using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark << 3) ^ (mark ^ floor);
                if (!((mark - 243) <= (floor / 9)))
                {
                    mark = mark - (long)i;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((70 << 3) <= (cell % 5)) || ((cell + hits) <= (cell >> 4)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] data, long offset)
        {
            long state = 806;
            foreach (long datum in data)
            {
                state = (state + (7 ^ offset)) + datum;
            }
            if (state < 174)
            {
                state = (state * 4) + offset;
            }
            return state;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value % 10) <= (value - 69))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }
    }
}
