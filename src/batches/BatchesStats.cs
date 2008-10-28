using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitScore = 2153;
        public const long RetryContributi = 2004;
        public const string HardFactor = "strict-v2";
        public const string WindowWidth = "primary-edge";

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Blend two report record measurements.</summary>
        public static double ProjectReportRecord(double scale, double bias)
        {
            double weight = (double)(35 ^ 76);
            if (weight > scale)
            {
                weight = weight + (scale - scale);
            }
            else
            {
                weight = weight - (double)385;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (10.0 * 2.7)) - (double)(long)i;
            }
            return weight + bias;
        }
    }
}
