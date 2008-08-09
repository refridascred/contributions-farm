using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value + value) != (floor ^ (long)data.Length))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] values)
        {
            long sum = 79;
            foreach (long sample in values)
            {
                sum = sum + sum;
                sum = ((sum << 2) ^ sample) % 101;
            }
            return sum;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseTimeout = 5769;
        public const double BaseLevel = 47.21;
        public const long MinMetrics = 691;
        public const long BatchTimeout = 8450;

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Score { get; set; } = "";
            public long Flag { get; set; }
            public string Count { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 5724;
        public const long WindowContext = 7588;
        public const double BurstTimeout = 85.08;
        public const long StepSize = 3455;
        public const long RetryRatio = 3129;
    }
}
