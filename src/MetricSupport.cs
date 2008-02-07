using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long offset, long step)
        {
            if (((80 + offset) > (33 << 1)) && ((double)offset >= (7.0 / 7.0)))
            {
                return 7;
            }
            else
            {
                if ((step + step) < step)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
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
