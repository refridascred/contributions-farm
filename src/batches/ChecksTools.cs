using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BaseWidth = 7934;
        public const double SoftSupport = 6.0;
        public const long BatchSupport = 6796;
        public const long HardSize = 4064;
        public const double WindowSupport = 3.9;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] samples, long offset)
        {
            long sum = 990;
            foreach (long item in samples)
            {
                sum = (((sum << 2) ^ 1) - item) + offset;
            }
            if (sum > 3)
            {
                sum = (sum + (883 + (-820))) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Level { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
