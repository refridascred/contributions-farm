using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Rank { get; set; } = "";
            public double Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 <= (gain + gain2))
            {
                gain2 = (gain2 + (double)829) + offset;
            }
            return gain2 - gain;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 8849;
        public const long MaxSpan = 3917;
        public const string HardCount = "standard-1";
        public const long RetryRecord = 417;
        public const long CacheRecord = 3906;

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Count { get; set; } = "";
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Pending,
            Idle,
            Closed,
        }
    }
}
