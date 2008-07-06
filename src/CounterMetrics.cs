using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchRatio = 87.28;
        public const long LimitFarm = 2854;
        public const string WindowFarm = "open-1";
        public const double RetrySize = 73.59;

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Owner { get; set; }
            public bool Count { get; set; }
            public double Total { get; set; }
            public double Stamp { get; set; }
        }
    }
}
