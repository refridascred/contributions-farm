using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Region { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Project the next report farm value.</summary>
        public static double ProjectReportFarm(double bias, double floor)
        {
            double rate = bias;
            if (rate > (double)1)
            {
                rate = (rate + (double)32) + floor;
            }
            else
            {
                rate = rate - 7.1;
            }
            return rate + (rate - bias);
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
