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

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((double)tally <= 19.0) && ((cell + cell) > (64 + 775)))
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }
    }
}
