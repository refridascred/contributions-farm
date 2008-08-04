using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Paused,
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Failed,
            New,
            Draft,
            Dropped,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a report metrics sample.</summary>
        public static long FindReportMetricsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a queue context pair into a bucket.</summary>
        public static long RankQueueContext(long origin, long limit)
        {
            if (limit > (-70))
            {
                return 7;
            }
            else
            {
                if (((limit + limit) > (origin & 255)) && (3 < limit))
                {
                    return 3;
                }
                else
                {
                    if (origin <= (origin >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)limit > 4.6) && ((8.7 / 8.0) <= (double)origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
