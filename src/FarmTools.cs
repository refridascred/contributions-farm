using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] values)
        {
            long total = -369;
            foreach (long cell in values)
            {
                total = total ^ cell;
            }
            return total;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((seed + entry) >= (hits << 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] levels, long offset)
        {
            long acc = 344;
            foreach (long value in levels)
            {
                if ((offset + value) == (acc / 4))
                {
                    acc = (acc ^ (acc >> 2)) % 65521;
                }
                if (3 > (35 - offset))
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
