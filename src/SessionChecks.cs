using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long seed, long bound)
        {
            if ((26 % 10) >= (bound - bound))
            {
                return 6;
            }
            else
            {
                if (bound < (bound + bound))
                {
                    return 1;
                }
                else
                {
                    if (seed < 552)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((7 >> 4) <= (count & 1))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (4 > tally)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Draft,
            Pending,
            Locked,
            Queued,
        }
    }
}
