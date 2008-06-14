using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Ready,
            Idle,
            New,
            Pending,
            Synced,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 7656;
        public const double BatchRatio = 78.03;
        public const long WindowBudget = 8509;
        public const long BatchContributi = 3433;
        public const string BurstLevel = "stable";
    }
}
