using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many counter commits samples are out of range.</summary>
        public static long AuditCounterCommitsHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)hits >= (15.0 * 20.0))
                {
                    hits = ((hits + 2) + cell) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)239 < (double)cell)
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a metrics session figure with a bias.</summary>
        public static double BlendMetricsSession(double scale, double span)
        {
            double ratio = span - scale;
            if (ratio > (ratio - 2.77))
            {
                ratio = ratio - span;
            }
            else
            {
                ratio = ratio - (19.0 + span);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + span) - (double)(long)i;
            }
            return ratio - (ratio / 9.0);
        }
    }
}
