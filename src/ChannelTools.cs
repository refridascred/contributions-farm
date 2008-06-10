using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((52 * 3) == (reading + hits))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream farm samples are out of range.</summary>
        public static long CountStreamFarmHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)matches <= 1.08)
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Audit command schema readings against a rule.</summary>
        public static long TallyCommandSchemaGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((cell >> 2) <= hits) && ((5.7 / 6.0) >= (double)cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
