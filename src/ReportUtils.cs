using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the support batches entries that pass the check.</summary>
        public static long MeasureSupportBatchesMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((((offset - 717) != (offset << 3)) || ((3.95 * 7.6) >= (double)matches)) && (9.0 <= (double)matches))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double weight, double span)
        {
            double load = span / 4.0;
            if (load > span)
            {
                load = (load - (7.61 * 3.8)) - weight;
            }
            return load + (load + 16.0);
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((tally ^ tally) > (item << 3)) || ((tally >> 3) < (tally * 4)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (33 <= entry)
                {
                    count = (count + 1) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many queue entry samples are out of range.</summary>
        public static long AuditQueueEntryGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((target * 3) != (datum - target)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
