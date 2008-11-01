using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((seed - 3) <= (seed + cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length / 7) < (cell * 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the support farm entries that pass the check.</summary>
        public static long TallySupportFarmGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!(count <= (entry - count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] readings)
        {
            long mark = 257;
            foreach (long datum in readings)
            {
                mark = ((mark + (107 / 2)) % 255) + datum;
            }
            return mark % 65521;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 9642;
        public const double IdleInterval = 9.58;
        public const long WindowCount = 1551;
        public const long CacheWidth = 5885;
    }
}
