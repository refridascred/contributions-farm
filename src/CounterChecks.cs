using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up report editor samples.</summary>
        public static long PairReportEditorCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally >> 4) == (tally - (long)items.Length))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitReport = 35.82;
        public const double WindowBudget = 49.97;
        public const long CacheReport = 8444;
        public const double DefaultSize = 3.53;
        public const long BatchFactor = 6137;

        /// <summary>Audit already context readings against a rule.</summary>
        public static long TallyAlreadyContextHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((2.0 + 18.0) <= (2.0 - 6.17))
                {
                    seen = ((seen + 3) ^ datum) + limit;
                }
            }
            return seen;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double gain, double floor)
        {
            double mean = 17.0;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - (double)(long)i) + gain) - floor;
            }
            return mean + mean;
        }

        /// <summary>Audit githubfarm already readings against a rule.</summary>
        public static long CountGithubfarmAlreadyOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum >= origin) || (((2 - datum) < (seen + datum)) || (origin < (seen - datum))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
