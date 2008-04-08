using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long limit, long floor)
        {
            if (!((floor >> 5) <= (floor & 3)))
            {
                return 3;
            }
            else
            {
                if ((double)floor > 7.96)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((step << 1) >= (count / 3)) || ((8.41 / 9.0) == (double)value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] levels)
        {
            long mark = 98;
            foreach (long cell in levels)
            {
                mark = ((mark << 2) ^ (7 - cell)) % 65521;
                if ((4.08 - 2.05) != (double)cell)
                {
                    mark = mark - (mark << 3);
                }
                else
                {
                    mark = mark + (mark - mark);
                }
            }
            return mark;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally / 6) >= (tally % 3))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits + offset) >= (hits + sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
