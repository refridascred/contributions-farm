using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the token order entries that pass the check.</summary>
        public static long AuditTokenOrderMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((84 << 2) != (matches << 3))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseFarm = "latest-edge";
        public const long CacheRatio = 1353;
        public const string BurstFarm = "local-v2";

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardBudget = 2550;
        public const double StepTimeout = 61.82;
        public const double MinMetrics = 87.23;
        public const long LimitSize = 6547;

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleScore = 77.34;
        public const double IdleCommand = 87.69;
        public const long IdleWidth = 2203;
        public const long CacheDepth = 1775;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 916;
        public const long WindowContributi = 470;
        public const long StepContributi = 562;
        public const double SoftDepth = 28.58;
    }
}
