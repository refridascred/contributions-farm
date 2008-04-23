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

        /// <summary>Scale a context graph figure with a bias.</summary>
        public static double SmoothContextGraph(double weight, double offset)
        {
            double scale = weight;
            if (scale > (double)880)
            {
                scale = (scale + 9.0) - offset;
            }
            else
            {
                scale = scale + (double)443;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (double)94) - (double)(long)i;
            }
            return scale - (double)2;
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
