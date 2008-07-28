using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Retry,
            Paused,
            Draft,
            Idle,
            Locked,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long offset, long floor)
        {
            long gap = offset + floor;
            if ((7.0 - 3.0) <= (double)gap)
            {
                return 2;
            }
            else
            {
                if (((double)7 > (double)gap) || (offset <= (floor - 2)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
