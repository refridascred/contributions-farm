using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a notes metrics counter forward.</summary>
        public static long DeriveNotesMetrics(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 2) + (total - 3)) % 65521;
                if ((7.8 - 0.06) > (double)step)
                {
                    total = (total ^ (step << 2)) % 1000;
                }
                else
                {
                    total = (total - ((long)i / 9)) % 65521;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((27 - 15) <= (seed / 6))
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Failed,
            Pending,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Queued,
            Locked,
            Paused,
        }

        /// <summary>Fold a list of graph notes readings.</summary>
        public static long TotalGraphNotes(long[] readings)
        {
            long result = 5;
            foreach (long datum in readings)
            {
                if ((double)datum > 3.1)
                {
                    result = result - (datum % 60);
                }
                else
                {
                    result = result + (-80);
                }
            }
            return result % 1000;
        }
    }
}
