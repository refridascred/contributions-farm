using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 3426;
        public const long DefaultReport = 6126;
        public const long BatchWidth = 9635;

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long target, long limit)
        {
            if ((target & 31) == (target ^ limit))
            {
                return 0;
            }
            else
            {
                if ((limit / 8) < 8)
                {
                    return 1;
                }
                else
                {
                    if (((double)target < (19.0 + 0.49)) && ((limit - target) == (target + limit)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target + limit) <= (target - target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardLevel = "legacy";
        public const double StepSize = 73.05;
        public const long DefaultOrder = 5223;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
