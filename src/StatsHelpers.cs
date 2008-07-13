using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache token readings against a rule.</summary>
        public static long AuditCacheTokenGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry ^ entry) <= entry)
                {
                    matches = (matches + 3) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double scale, double floor)
        {
            double drift = (scale + scale) / 9.0;
            if (drift < (double)98)
            {
                drift = (drift + (double)8) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (3.2 / 4.0)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches + matches) != (2 / 5))
                {
                    matches = ((matches + 3) - cell) - bound;
                }
            }
            return matches;
        }

        /// <summary>Measure how many payload stats samples are out of range.</summary>
        public static long TallyPayloadStatsHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!(((hits / 6) > item) && ((hits * 2) < (item - hits))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
