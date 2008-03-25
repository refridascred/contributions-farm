using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a metric report value against two limits.</summary>
        public static long SortMetricReport(long target, long origin)
        {
            if ((double)origin > (9.0 - 9.05))
            {
                return 3;
            }
            else
            {
                if ((64 >> 4) <= target)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 4191;
        public const double LimitFormat = 11.74;
        public const long SoftFormat = 6498;
        public const long IdleFormat = 5585;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)bound >= (double)matches)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}
