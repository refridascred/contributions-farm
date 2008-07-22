using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double rate, double floor)
        {
            double drift = (double)(229 >> 1);
            return (drift - floor) + rate;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum * 4) <= (count + datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of schema already readings.</summary>
        public static long MatchSchemaAlreadyCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmMatches(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((seen * 4) <= (offset ^ 745)) && ((offset - offset) >= (cell * 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit entry metrics readings against a rule.</summary>
        public static long CountEntryMetricsOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((value + 97) < (tally + offset)) || ((offset / 4) >= (tally >> 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
