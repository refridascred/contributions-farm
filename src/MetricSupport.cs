using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long origin, long floor)
        {
            if ((double)floor < 20.0)
            {
                return 1;
            }
            else
            {
                if ((double)origin > 12.0)
                {
                    return 2;
                }
                else
                {
                    if ((double)floor != (4.0 / 7.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)origin > (4.1 * 8.2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading / 5) == (tally + tally))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 3) + (seed / 2)) % 101;
                if ((seed >> 3) > ((long)i << 1))
                {
                    total = (total << 2) ^ (866 + seed);
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
