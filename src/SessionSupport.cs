using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] series, long target)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (count < (count - count))
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long target, long step)
        {
            if ((step - 96) < (step / 4))
            {
                return 6;
            }
            else
            {
                if (756 < step)
                {
                    return 0;
                }
                else
                {
                    if ((target << 3) == (target / 6))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
