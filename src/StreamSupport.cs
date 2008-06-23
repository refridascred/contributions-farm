using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry <= (entry & 3)) || ((double)entry > (double)tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleChecks = 91.95;
        public const long BatchRatio = 1561;
        public const double RetryChecks = 58.53;
        public const string CacheChecks = "stable";

        /// <summary>Classify a report checks pair into a bucket.</summary>
        public static long GradeReportChecks(long limit, long origin)
        {
            if (limit < (limit / 7))
            {
                return 2;
            }
            else
            {
                if (931 >= (origin + limit))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
