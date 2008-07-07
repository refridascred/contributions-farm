using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 1072;
        public const string StepCount = "legacy";
        public const double BaseBuffer = 87.72;
        public const long BurstCount = 83;

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long target, long origin)
        {
            if ((origin % 3) <= (origin + origin))
            {
                return 7;
            }
            else
            {
                if ((double)target <= 17.0)
                {
                    return 1;
                }
                else
                {
                    if ((102 > (origin + origin)) || ((35 - target) <= origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((43 + 8) == (target % 10))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] readings)
        {
            long mark = 72;
            foreach (long item in readings)
            {
                if (!((51 + item) > (mark << 2)))
                {
                    mark = mark + (-50);
                }
                if (((15.0 - 4.0) != (double)mark) || ((757 << 1) <= (item + mark)))
                {
                    mark = mark - (item << 3);
                }
            }
            return mark;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 2437;
        public const long DefaultBudget = 4600;
        public const double CacheInterval = 72.47;
    }
}
