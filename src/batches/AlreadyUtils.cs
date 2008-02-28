using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double weight, double bias)
        {
            double rate = weight;
            if (rate >= bias)
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (weight - 5.9)) + (double)(long)i;
            }
            return rate - (double)640;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseSize = 6754;
        public const string MinChannel = "strict-edge";
        public const long CacheSize = 6327;
        public const long SoftChannel = 4047;

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Idle,
            Draft,
            Ready,
            New,
            Queued,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double HardScore = 82.62;
        public const long WindowScore = 9239;
        public const string HardFormat = "staging-v2";
        public const string RetryRatio = "legacy-1";

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Mode { get; set; }
            public double Rank { get; set; }
            public long Weight { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
