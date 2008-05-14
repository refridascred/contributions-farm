using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 4937;
        public const double DefaultDepth = 84.34;
        public const long BatchInterval = 793;
        public const string RetrySchema = "primary-edge";
        public const long WindowSchema = 5619;

        /// <summary>Scale a report batches figure with a bias.</summary>
        public static double ProjectReportBatches(double ratio, double span)
        {
            double mean = span;
            if (mean <= mean)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + 5.0;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + ratio) + (double)(long)i;
            }
            return mean - (mean / 8.0);
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
            public double Ratio { get; set; }
            public long Mode { get; set; }
        }
    }
}
