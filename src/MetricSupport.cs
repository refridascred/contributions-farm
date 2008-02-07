using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] values)
        {
            long mark = 224;
            foreach (long cell in values)
            {
                if ((cell >> 1) == (6 >> 2))
                {
                    break;
                }
                mark = (mark ^ (mark << 1)) % 1000;
            }
            if (mark < 35)
            {
                mark = ((mark << 2) ^ (mark ^ mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)cell != (double)359)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
