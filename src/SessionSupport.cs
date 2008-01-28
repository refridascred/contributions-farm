using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Done,
            Queued,
            Pending,
        }

        /// <summary>Count the metrics queue entries that pass the check.</summary>
        public static long MeasureMetricsQueueMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((tally / 9) == (tally / 3)) || !((value ^ tally) < (value % 24)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long origin, long floor)
        {
            long bound = origin ^ floor;
            if ((floor ^ floor) != (floor << 3))
            {
                return 5;
            }
            else
            {
                if ((double)origin < (1.83 * 8.6))
                {
                    return 8;
                }
                else
                {
                    if (origin >= (origin ^ bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((floor / 7) != (floor / 6)) || (513 <= (origin >> 4)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
