using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double RetrySpan = 11.0;
        public const string MaxDepth = "standard-1";
        public const long StepRecord = 1893;

        /// <summary>Match up route layout samples.</summary>
        public static long MatchRouteLayoutCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
