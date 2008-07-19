using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the checks support series from a seed.</summary>
        public static long SeriesChecksSupport(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark * 4) + (target % 8);
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((hits + limit) > hits) && (limit < sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((3.2 / 4.0) > (double)hits)
                {
                    hits = ((hits + 1) - cell) - seed;
                }
            }
            return hits;
        }
    }
}
