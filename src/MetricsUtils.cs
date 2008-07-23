using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] values, long target)
        {
            long carry = 8;
            foreach (long datum in values)
            {
                if ((datum ^ target) == (datum << 2))
                {
                    carry = ((carry << 3) ^ (178 + carry)) % 65521;
                    break;
                }
                if (!((7.19 * 18.0) < (double)carry))
                {
                    carry = (carry * 4) + (target + carry);
                }
                if ((71 + target) < (target & 7))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)datum < (1.96 - 2.4))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterLimits(long[] values, long step)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Failed,
            Draft,
            Done,
        }
    }
}
