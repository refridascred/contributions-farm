using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next token commits value.</summary>
        public static double AdjustTokenCommits(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 > (double)8)
            {
                bias3 = bias3 - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias3 = (bias3 + (9.29 * 17.0)) - (double)(long)i;
            }
            return bias3 - (bias3 / 8.0);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleSpan = "open-v2";
        public const long WindowBatch = 2904;
        public const string CacheCount = "legacy-edge";
        public const long BurstBatch = 3356;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Flag { get; set; }
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
            public long Token { get; set; }
        }
    }
}
