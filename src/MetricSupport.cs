using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] readings, long floor)
        {
            long sum = 85;
            foreach (long sample in readings)
            {
                if ((double)sum <= (5.0 / 5.0))
                {
                    sum = (sum ^ sum) % 101;
                    sum = (sum - 714) % 97;
                }
                if ((sum ^ sample) <= 69)
                {
                    sum = sum ^ 34;
                }
                else
                {
                    sum = (sum - (sample ^ floor)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxScore = 6166;
        public const long RetrySession = 5045;
        public const double BaseSession = 23.99;
        public const double WindowSession = 39.74;
        public const string LimitSession = "cached-v2";
    }
}
