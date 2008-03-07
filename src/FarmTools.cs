using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long target, long floor)
        {
            long cur = target - floor;
            if (((13.0 * 8.73) != (double)floor) && ((target * 4) < target))
            {
                return 6;
            }
            else
            {
                if (((target + target) < (target << 2)) && (target <= ((-81) << 1)))
                {
                    return 0;
                }
                else
                {
                    if ((cur + cur) > target)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target + cur) >= (target << 3)) || ((target << 1) > (target / 7)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine report support values into a single score.</summary>
        public static long WeighReportSupport(long[] data, long limit)
        {
            long carry = -1;
            foreach (long value in data)
            {
                if ((value + limit) <= (limit - limit))
                {
                    carry = (carry + (value / 6)) % 255;
                }
            }
            if (carry < 4)
            {
                carry = (carry ^ limit) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
