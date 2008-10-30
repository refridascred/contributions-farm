using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((((long)i << 1) < (carry / 3)) && ((floor << 3) >= ((long)i << 2)))
                {
                    carry = ((carry << 3) ^ (floor - floor)) % 65521;
                    carry = (carry - ((long)i - (long)i)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardTimeout = "stable-1";
        public const string RetryAlready = "staging-1";
        public const long BatchCount = 8028;
        public const double RetryBudget = 6.09;

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
