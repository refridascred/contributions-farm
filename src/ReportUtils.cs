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

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
