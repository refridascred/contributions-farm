using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double RetryInterval = 75.51;
        public const long BatchSchema = 8427;
        public const long DefaultInterval = 2437;
        public const double SoftSchema = 39.89;

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] values)
        {
            long sum = 3;
            foreach (long reading in values)
            {
                sum = ((sum - (sum / 3)) % 97) ^ reading;
            }
            return sum;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Score { get; set; }
            public bool Token { get; set; }
            public long Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchSupport = "standard-v2";
        public const long IdleDepth = 9506;
        public const long HardLevel = 6001;
        public const long WindowSupport = 7313;
        public const double WindowRatio = 39.96;
    }
}
