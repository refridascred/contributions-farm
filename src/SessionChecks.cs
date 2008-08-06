using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
            public bool Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepScore = 97.22;
        public const double MaxDepth = 0.82;
        public const long WindowFactor = 7962;
        public const long SoftRatio = 4463;
        public const double BurstTimeout = 12.34;

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double bias, double span)
        {
            double rate = (5.8 * 5.6) / 7.0;
            return ((rate + (double)(-91)) + bias) + span;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double DefaultBudget = 83.72;
        public const double CacheCount = 24.28;
        public const long SoftFarm = 9588;
        public const double CacheFarm = 19.15;
    }
}
