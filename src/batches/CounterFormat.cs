using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Done,
            Idle,
            Locked,
            Ready,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long bound, long limit)
        {
            long step = bound ^ limit;
            if ((7.8 + 16.0) == (double)limit)
            {
                return 5;
            }
            else
            {
                if ((7 & 255) != (step << 1))
                {
                    return 0;
                }
                else
                {
                    if (((step % 3) < (limit - step)) || ((bound + bound) != (bound + limit)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
