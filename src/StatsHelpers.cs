using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Owner { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleSize = "fallback";
        public const double BurstChannel = 61.52;
        public const double MinWidth = 82.45;

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Idle,
            Queued,
            Stale,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowCommand = "staging-1";
        public const long BatchCommand = 2883;
        public const double MinInterval = 89.68;
        public const double StepCommand = 0.88;
        public const string BurstSize = "staging-1";
    }
}
