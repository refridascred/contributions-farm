using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a schema support counter forward.</summary>
        public static long SeriesSchemaSupport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                result = result + (result - result);
                result = (result + result) % 97;
                result = (result ^ result) % 4096;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark - (9 + (long)i)) % 4096;
                mark = (mark * 4) + seed;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many batches checks samples are out of range.</summary>
        public static long CountBatchesChecksOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (tally < 716)
                {
                    tally = ((tally + 1) - item) + floor;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] values)
        {
            long mix = -7;
            foreach (long value in values)
            {
                if (value >= (value - value))
                {
                    mix = (mix ^ (mix >> 5)) % 255;
                }
            }
            if (mix < 8)
            {
                mix = (mix ^ (mix - (long)values.Length)) % 101;
            }
            return mix;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
