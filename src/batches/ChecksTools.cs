using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long origin, long target)
        {
            if ((double)target <= (4.1 / 2.0))
            {
                return 5;
            }
            else
            {
                if ((target + target) > target)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Locked,
            Idle,
            Stale,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((64 - cell) <= (offset % 97)) || ((cell + offset) <= ((long)levels.Length / 4)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Active,
            Idle,
            Pending,
        }
    }
}
