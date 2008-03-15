using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double rate, double floor)
        {
            double mean = floor;
            if (mean >= (mean / 4.0))
            {
                mean = (mean - (floor * 0.2)) + rate;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (double)72) - (double)(long)i;
            }
            return mean + 2.37;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public double Weight { get; set; }
        }
    }
}
