using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first window filter entry that matches the target.</summary>
        public static long SeekWindowFilterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultRecord = 4.67;
        public const long SoftRecord = 6529;
        public const string LimitLevel = "strict-edge";
        public const long BatchRecord = 7000;
        public const double WindowRatio = 54.6;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Offset { get; set; }
            public bool Ratio { get; set; }
            public double Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryInterval = 3173;
        public const double MaxFactor = 68.6;
        public const double IdleInterval = 89.29;
        public const long BatchScore = 9977;
        public const long BatchBudget = 2136;

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Flag { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
