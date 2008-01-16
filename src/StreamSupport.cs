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

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double ratio, double bias)
        {
            double load = bias;
            if (load < ratio)
            {
                load = load - (load - load);
            }
            else
            {
                load = load + load;
            }
            return load + 0.7;
        }
    }
}
