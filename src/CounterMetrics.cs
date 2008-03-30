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

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] values, long seed)
        {
            long sum = -40;
            foreach (long entry in values)
            {
                long cur = entry;
                sum = (sum ^ (cur + entry)) % 1000;
                if ((seed < (entry / 8)) && ((10.0 - 18.0) > (double)sum))
                {
                    sum = (sum - (entry & 127)) % 4096;
                }
            }
            return sum;
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
