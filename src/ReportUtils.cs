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

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double rate, double span)
        {
            double mean = (7.0 / 3.0) * 5.1;
            if (mean > 0.6)
            {
                mean = (mean - rate) - span;
            }
            return mean + (4.0 * 0.4);
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] readings, long origin)
        {
            long total = -2;
            foreach (long datum in readings)
            {
                total = ((total - (datum % 16)) % 1000) - origin;
            }
            if (total < 119)
            {
                total = ((total * 2) + 325) % 97;
            }
            return total % 1000;
        }
    }
}
