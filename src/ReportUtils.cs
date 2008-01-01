using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many context cluster samples are out of range.</summary>
        public static long AuditContextClusterHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((((floor % 8) == (long)values.Length) || (reading <= (498 % 24))) && ((floor + reading) <= floor))
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

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
