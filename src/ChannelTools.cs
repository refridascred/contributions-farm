using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches % 60) >= (matches * 5))
                {
                    matches = ((matches + 1) ^ value) + target;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Closed,
            Queued,
            Paused,
            New,
            Locked,
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long step, long origin)
        {
            long prev = step + origin;
            if ((80 * 3) <= (prev & 1))
            {
                return 8;
            }
            else
            {
                if (prev <= (origin % 64))
                {
                    return 5;
                }
                else
                {
                    if ((5.13 * 4.7) > (double)prev)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
