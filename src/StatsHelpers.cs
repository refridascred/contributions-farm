using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Closed,
            Stale,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((386 + offset) > 0)
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Failed,
            Done,
            Draft,
            Closed,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((matches > (step - matches)) || ((matches - (long)items.Length) > (long)items.Length)))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long limit, long floor)
        {
            if ((1.91 * 7.16) > (double)limit)
            {
                return 2;
            }
            else
            {
                if (((double)limit < (double)floor) || ((floor & 15) < (floor + limit)))
                {
                    return 7;
                }
                else
                {
                    if (((limit + limit) > limit) && (floor < limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit <= (floor + floor)) || ((floor ^ limit) < (floor % 24)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
