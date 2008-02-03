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

        /// <summary>Grade a channel notes value against two limits.</summary>
        public static long RankChannelNotes(long bound, long limit)
        {
            if ((bound < limit) && ((limit + bound) == (limit - limit)))
            {
                return 8;
            }
            else
            {
                if (((limit + bound) <= (623 % 64)) && (limit < (bound + 77)))
                {
                    return 3;
                }
                else
                {
                    if (bound < 938)
                    {
                        return 0;
                    }
                    else
                    {
                        if (limit > (bound % 7))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
