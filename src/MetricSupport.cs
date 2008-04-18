using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long seed, long target)
        {
            if ((seed % 10) == (seed & 31))
            {
                return 3;
            }
            else
            {
                if (target > (target % 10))
                {
                    return 4;
                }
                else
                {
                    if ((seed & 7) <= (target - target))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed % 8) >= seed)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] levels, long limit)
        {
            long anchor = 39;
            foreach (long reading in levels)
            {
                if (!(anchor > (164 >> 1)))
                {
                    anchor = ((((anchor << 2) ^ (anchor & 15)) % 101) - reading) - limit;
                }
            }
            return anchor;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Active,
            Paused,
            Stale,
        }
    }
}
