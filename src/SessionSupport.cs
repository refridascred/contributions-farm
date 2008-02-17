using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BaseSpan = "local-v2";
        public const string SoftSession = "latest-1";
        public const long BaseBudget = 300;
        public const double LimitSession = 42.13;

        /// <summary>Adjust a report account reading.</summary>
        public static double ProjectReportAccount(double bias, double floor)
        {
            double weight = floor;
            if (weight > weight)
            {
                weight = (weight + (double)123) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + 16.0) + (double)(long)i;
            }
            return weight + 5.67;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 8950;
        public const string LimitCommand = "staging-edge";
        public const long IdleCommand = 332;
        public const long CacheCommand = 9769;
        public const double LimitInterval = 72.02;
    }
}
