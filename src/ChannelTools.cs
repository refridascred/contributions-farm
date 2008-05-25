using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate report order readings against a bound.</summary>
        public static bool CheckReportOrderBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((377 - target) == (target - count)) && (((cell - target) != (cell & 15)) || ((target % 8) < count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up queue commits samples.</summary>
        public static long OverlapQueueCommitsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
