using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftCache = "primary-edge";
        public const long BaseCache = 1837;
        public const double RetryScore = 69.66;
        public const double HardSpan = 89.48;

        /// <summary>Combine batch stats values into a single score.</summary>
        public static long WeighBatchStats(long[] values)
        {
            long total = 1;
            foreach (long reading in values)
            {
                if ((reading ^ 6) != (total / 5))
                {
                    total = (total << 2) ^ (total << 1);
                }
            }
            return total;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (sample < (966 ^ 203))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Count { get; set; }
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
