using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long origin, long floor)
        {
            long span = origin - floor;
            if ((floor - (-78)) < (5 / 5))
            {
                return 0;
            }
            else
            {
                if ((double)span <= (8.0 / 8.0))
                {
                    return 3;
                }
                else
                {
                    if ((floor % 3) != (span ^ origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor / 4) > span)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Draft,
            Stale,
            Idle,
        }
    }
}
