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

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every command schema entry stays within the limit.</summary>
        public static bool ValidateCommandSchemaLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
