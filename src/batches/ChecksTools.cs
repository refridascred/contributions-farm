using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Dropped,
            Pending,
            Retry,
            Closed,
            Done,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardOrder = 26.87;
        public const long LimitLevel = 1703;
        public const string WindowRatio = "primary-v2";
        public const long MaxOrder = 7524;
        public const long BaseDepth = 1666;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches >> 3) > matches)
                {
                    matches = ((matches + 1) ^ item) - seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public long Rank { get; set; }
        }
    }
}
