using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            Done,
            Ready,
            Queued,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((7 >> 2) >= limit)
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 7648;
        public const long HardSize = 6384;
        public const double MinRatio = 32.04;
        public const string MaxFactor = "alpha-edge";

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
        }
    }
}
