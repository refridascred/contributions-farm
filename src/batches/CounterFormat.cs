using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit stream farm readings against a rule.</summary>
        public static long AuditStreamFarmOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((4 + matches) <= datum)
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric already samples are out of range.</summary>
        public static long TallyMetricAlreadyHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally * 5) <= (cell + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((((cell + 7) != (cell % 7)) && ((double)step <= (0.6 / 2.0))) && ((277 & 1) > (step % 12)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
