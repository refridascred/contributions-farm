using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long target, long step)
        {
            if (!((5 >> 1) >= (257 + target)))
            {
                return 3;
            }
            else
            {
                if ((target + target) <= target)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Retry,
            Paused,
            Idle,
        }

        /// <summary>Validate batch command readings against a bound.</summary>
        public static bool GuardBatchCommandBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
