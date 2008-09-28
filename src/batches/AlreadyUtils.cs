using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCount = 6995;
        public const long MaxCommand = 1206;
        public const long BatchCommand = 8751;
        public const double MinRatio = 13.89;

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 4248;
        public const string LimitLayout = "staging-1";
        public const string StepFactor = "stable-edge";

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Limit { get; set; }
            public long Rank { get; set; }
            public double Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many metric tools samples are out of range.</summary>
        public static long CountMetricToolsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((matches - matches) <= matches) && (((360 * 5) <= item) || ((item % 100) < (item - item))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
            public double Total { get; set; }
            public double Region { get; set; }
        }
    }
}
