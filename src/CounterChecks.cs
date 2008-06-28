using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepRatio = 5379;
        public const long DefaultCluster = 775;
        public const string CacheInterval = "fallback-v2";
        public const string BatchSize = "fallback";
        public const string CacheRatio = "primary";

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxEntry = 53.72;
        public const double LimitInterval = 31.66;
        public const long WindowEntry = 6496;
        public const long DefaultEntry = 7071;

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (75 >= (seen / 5))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] items, long limit)
        {
            long sum = 7;
            foreach (long value in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = ((sum + 9) % 101) ^ (long)i;
                }
                if (!((sum + limit) >= (value << 2)))
                {
                    sum = sum ^ (limit / 9);
                }
                sum = (sum * 5) + value;
            }
            return sum % 4096;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long step, long offset)
        {
            if (256 < (offset - step))
            {
                return 7;
            }
            else
            {
                if ((step - step) <= (offset - step))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
