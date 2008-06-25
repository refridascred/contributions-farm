using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long offset, long offset2)
        {
            if ((offset << 1) > offset2)
            {
                return 2;
            }
            else
            {
                if ((offset - offset2) >= offset)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((hits % 10) <= (datum ^ datum)) && ((double)hits == (double)datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!((count > floor) || ((double)sample > (1.7 - 11.0))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
