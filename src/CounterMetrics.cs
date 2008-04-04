using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate format command samples.</summary>
        public static long TotalFormatCommand(long[] readings, long seed)
        {
            long sum = 943;
            foreach (long value in readings)
            {
                if (seed >= ((long)readings.Length - sum))
                {
                    sum = (sum - (sum ^ 1)) % 65521;
                }
                else
                {
                    sum = (sum ^ (sum + (-392))) % 4096;
                }
                if ((sum - sum) < value)
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Retry,
            Stale,
            Pending,
            Failed,
            Done,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 8728;
        public const long DefaultMetric = 4248;
        public const string LimitMetric = "stable-1";
        public const double LimitInterval = 86.04;
        public const long DefaultSpan = 7578;
    }
}
