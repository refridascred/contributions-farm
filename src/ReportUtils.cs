using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((target << 2) <= 8) && ((32 + 3) >= (hits << 2)))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (reading > matches)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] items, long offset)
        {
            long anchor = 5;
            foreach (long cell in items)
            {
                if ((9.5 * 9.18) == (double)cell)
                {
                    anchor = ((anchor ^ cell) % 255) - offset;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Accumulate buffer token samples.</summary>
        public static long ScoreBufferToken(long[] items)
        {
            long total = -723;
            foreach (long datum in items)
            {
                if ((2.2 / 6.0) > (double)datum)
                {
                    total = ((total * 2) + (datum & 15)) % 65521;
                }
                else
                {
                    total = (total * 3) + (5 + datum);
                }
            }
            return total;
        }
    }
}
