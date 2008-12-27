using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Paused,
            Pending,
            Failed,
            Queued,
            New,
        }

        /// <summary>Rank contributi metric input into a small class.</summary>
        public static long SortContributiMetric(long origin, long floor)
        {
            long cur = origin + floor;
            if ((20.0 / 2.0) == (double)origin)
            {
                return 4;
            }
            else
            {
                if ((double)origin != (double)cur)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
