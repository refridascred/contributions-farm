using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((6.75 - 3.0) <= (double)datum)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the checks filter entries that pass the check.</summary>
        public static long MeasureChecksFilterMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((bound ^ reading) < (reading * 2))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Ready,
            Active,
            New,
            Failed,
            Locked,
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((384 - (-9)) >= (tally + floor))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }
    }
}
