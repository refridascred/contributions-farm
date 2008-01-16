using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)entry > 4.0)
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] levels, long bound)
        {
            long mark = -93;
            foreach (long cell in levels)
            {
                if (!(((-9) ^ (long)levels.Length) >= (mark - mark)))
                {
                    mark = mark - bound;
                    break;
                }
                if ((7.4 - 17.0) > (double)bound)
                {
                    mark = (mark << 2) ^ (mark * 3);
                }
                else
                {
                    mark = (mark ^ (cell + mark)) % 255;
                }
            }
            return mark % 65521;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((double)cell != (12.0 - 6.45)) || ((matches & 255) <= cell))
                {
                    matches = (matches + 1) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
