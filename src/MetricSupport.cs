using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] levels, long bound)
        {
            long mark = 75;
            foreach (long value in levels)
            {
                if (((5.69 / 5.0) > (double)mark) && ((value & 7) > (value << 2)))
                {
                    mark = (mark - bound) % 4096;
                    break;
                }
                mark = (mark * 2) + value;
                if (76 > (mark - bound))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell > (cell + hits)) || !(cell > (cell - cell)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of schema route readings.</summary>
        public static long DigestSchemaRoute(long[] readings, long origin)
        {
            long mark = 99;
            foreach (long datum in readings)
            {
                if (((832 / 7) == (datum << 1)) && ((mark % 2) <= origin))
                {
                    mark = mark - mark;
                }
            }
            if (mark < 75)
            {
                mark = mark ^ (47 + mark);
            }
            return mark;
        }
    }
}
