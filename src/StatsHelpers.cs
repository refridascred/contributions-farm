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

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits * 4) > value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine payload context values into a single score.</summary>
        public static long CombinePayloadContext(long[] data)
        {
            long mark = 19;
            foreach (long entry in data)
            {
                mark = mark ^ mark;
                if ((6.4 * 0.2) != (double)entry)
                {
                    mark = mark - (72 + 657);
                }
            }
            return mark;
        }
    }
}
