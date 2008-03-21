using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many layout window samples are out of range.</summary>
        public static long CountLayoutWindowHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen > (seen * 5))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits ^ sample) <= (hits - hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                long matches = ((long)i - acc) + acc;
                matches = ((matches * 3) + (acc ^ bound)) % 1000;
                if (!(((9.96 / 2.0) > (double)matches) || ((matches >> 5) != (matches / 2))))
                {
                    matches = matches + ((long)i + (long)i);
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
