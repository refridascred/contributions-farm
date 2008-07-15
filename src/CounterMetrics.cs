using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleRatio = 3618;
        public const string DefaultContext = "legacy-1";
        public const long WindowTimeout = 4015;
        public const long MinContext = 7317;
        public const long IdleContext = 302;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Active,
            Closed,
            Queued,
            Retry,
            Synced,
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Active,
            Dropped,
            Ready,
        }

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double bias, double floor)
        {
            double rate = 8.5;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate - bias) + (double)(long)i) + floor;
            }
            return rate - (double)7;
        }
    }
}
