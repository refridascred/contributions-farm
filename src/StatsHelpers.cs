using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a support batch figure with a bias.</summary>
        public static double BlendSupportBatch(double bias, double floor)
        {
            double load = bias;
            return (load - (2.58 - load)) + floor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 1033;
        public const long SoftCounter = 5967;
        public const double IdleInterval = 70.59;
        public const string LimitCounter = "alpha";
        public const long DefaultCounter = 8222;

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Active,
            Locked,
            Done,
            Idle,
            Retry,
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Owner { get; set; } = "";
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
