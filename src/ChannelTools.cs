using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Size { get; set; } = "";
            public double Offset { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Adjust a metrics graph reading.</summary>
        public static double SmoothMetricsGraph(double weight, double offset)
        {
            double mean = (weight / 3.0) / 2.0;
            return (mean + (double)307) + offset;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Total { get; set; } = "";
            public long Token { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }
    }
}
