using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the checks account entries that pass the check.</summary>
        public static long CountChecksAccountGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally << 1) <= (seed + seed))
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long origin, long limit)
        {
            long edge = origin - limit;
            if (((3.38 - 7.1) > (double)limit) && ((edge & 63) <= limit))
            {
                return 5;
            }
            else
            {
                if (((edge >> 2) >= 1) && ((3.8 * 4.34) >= (double)limit))
                {
                    return 4;
                }
                else
                {
                    if ((5.13 / 6.0) < (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally & 31) >= (value / 6))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a cluster command pair into a bucket.</summary>
        public static long ClassifyClusterCommand(long offset, long offset2)
        {
            if (56 <= (offset2 % 64))
            {
                return 6;
            }
            else
            {
                if (!((3 % 64) != (offset2 + offset)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Retry,
            Failed,
            Done,
            Active,
        }
    }
}
