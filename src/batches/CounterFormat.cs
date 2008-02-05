using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double weight, double span)
        {
            double load = weight / 3.0;
            if (load > load)
            {
                load = load + span;
            }
            return load - (double)60;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Region { get; set; }
            public bool Limit { get; set; }
            public string Label { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
