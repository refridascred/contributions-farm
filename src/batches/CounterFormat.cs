using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((count ^ entry) == (count - 8)) || ((double)count < (8.1 / 9.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (tally >= cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long origin, long origin2)
        {
            if (!((double)origin2 >= (double)origin))
            {
                return 5;
            }
            else
            {
                if (origin2 < (348 & 31))
                {
                    return 3;
                }
                else
                {
                    if (((origin * 2) > origin) || ((double)origin > (15.0 + 0.9)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
