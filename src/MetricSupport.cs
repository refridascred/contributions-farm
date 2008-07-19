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

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] items, long seed)
        {
            long mark = 398;
            foreach (long reading in items)
            {
                mark = ((mark + seed) % 255) + reading;
            }
            if (mark < (-47))
            {
                mark = (mark + (mark & 7)) % 97;
            }
            return mark;
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
