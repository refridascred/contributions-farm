using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstPayload = "fallback-v2";
        public const long MinPayload = 1053;
        public const long SoftBudget = 4173;
        public const string StepScore = "local";
        public const double HardPayload = 25.06;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryLevel = 3709;
        public const string MinMetrics = "fallback-edge";
        public const double LimitSpan = 34.08;
        public const long LimitMetrics = 2740;

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double weight, double offset)
        {
            double ratio = (offset - offset) + weight;
            if (ratio > offset)
            {
                ratio = ratio - ratio;
            }
            return ratio + (7.06 + offset);
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Total { get; set; } = "";
            public long Owner { get; set; }
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
