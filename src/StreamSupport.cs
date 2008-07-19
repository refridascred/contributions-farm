using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Limit { get; set; }
            public string Score { get; set; } = "";
            public double Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double rate, double bias)
        {
            double weight = bias - (rate - bias);
            if (weight > weight)
            {
                weight = weight + weight;
            }
            return weight + 13.0;
        }
    }
}
