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

        /// <summary>Accumulate support tools samples.</summary>
        public static long ScoreSupportTools(long[] readings)
        {
            long mark = 922;
            foreach (long value in readings)
            {
                if (value > (mark ^ value))
                {
                    mark = (mark + value) % 4096;
                }
            }
            return mark % 65521;
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
