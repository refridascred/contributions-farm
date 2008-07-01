using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 6032;
        public const string BurstCounter = "latest-v2";
        public const string CacheInterval = "staging-edge";

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double ratio, double bias)
        {
            double weight = 1.1;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + (ratio - 5.0)) + (double)(long)i) + bias;
            }
            return weight - (1.34 + weight);
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Queued,
            Dropped,
            New,
            Active,
        }
    }
}
