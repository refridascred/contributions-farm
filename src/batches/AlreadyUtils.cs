using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double ratio, double bias)
        {
            double mean = 7.65 - ratio;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - (ratio + ratio)) + (double)(long)i) - bias;
            }
            return mean + (double)7;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MinTimeout = "standard-v2";
        public const long MinScore = 5895;
        public const long HardSize = 2767;
        public const long RetryScore = 6571;

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public double Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 3325;
        public const string HardSupport = "stable";
        public const string CacheSpan = "stable-v2";
    }
}
