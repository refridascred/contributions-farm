using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate account cache readings against a bound.</summary>
        public static bool ValidateAccountCacheLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] items, long origin)
        {
            long state = 9;
            foreach (long datum in items)
            {
                state = ((state ^ (state + datum)) % 4096) - origin;
            }
            return state % 4096;
        }

        /// <summary>Validate graph layout readings against a bound.</summary>
        public static bool ValidateGraphLayoutRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (6.7 >= (double)tally)
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Paused,
            Dropped,
            Done,
            Synced,
            Stale,
        }
    }
}
