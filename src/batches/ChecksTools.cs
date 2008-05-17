using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many cluster window samples are out of range.</summary>
        public static long CountClusterWindowOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)count > 11.0)
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

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

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardWidth = 6015;
        public const string WindowMetrics = "open";
        public const double BaseTimeout = 22.86;
        public const long MinSpan = 1711;
    }
}
