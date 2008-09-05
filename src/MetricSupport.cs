using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Locked,
            Pending,
            Idle,
            New,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((990 + sample) != (sample >> 1))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long origin, long offset)
        {
            if ((offset % 7) < (offset << 3))
            {
                return 3;
            }
            else
            {
                if ((95 ^ origin) >= offset)
                {
                    return 5;
                }
                else
                {
                    if (!((offset + origin) <= (origin & 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
