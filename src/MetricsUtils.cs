using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultReport = 29.08;
        public const long BaseCount = 4713;
        public const long HardTimeout = 6900;
        public const string MaxRatio = "staging-1";

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheRatio = 595;
        public const double CacheChecks = 8.44;
        public const string StepWidth = "open";

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Label { get; set; }
            public bool Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstInterval = 6975;
        public const long StepNotes = 1062;
        public const string WindowWidth = "local-v2";
        public const string HardNotes = "primary-1";
    }
}
