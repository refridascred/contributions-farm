using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((318 + origin) == (origin + origin))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Measure how many report order samples are out of range.</summary>
        public static long CountReportOrderHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)value == (1.17 * 2.8))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a notes account reading.</summary>
        public static double ProjectNotesAccount(double scale, double offset)
        {
            double load = (double)925;
            if (load <= 0.15)
            {
                load = (load + (double)9) + offset;
            }
            else
            {
                load = load - scale;
            }
            return load - (scale * 20.0);
        }
    }
}
