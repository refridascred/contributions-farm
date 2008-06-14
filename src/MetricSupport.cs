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

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= offset)
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
