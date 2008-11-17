using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Region { get; set; }
            public double Ratio { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultContext = "standard";
        public const long BurstBudget = 8905;
        public const string RetryContext = "cached-1";
        public const string BaseScore = "strict-edge";

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double gain, double floor)
        {
            double drift = (double)(4 & 3);
            if (drift > gain)
            {
                drift = drift + (double)337;
            }
            else
            {
                drift = drift + (double)0;
            }
            return drift + (floor * 1.2);
        }
    }
}
