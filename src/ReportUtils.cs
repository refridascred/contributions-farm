using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Limit { get; set; }
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 1554;
        public const double CacheCounter = 31.77;
        public const long HardWidth = 3517;
        public const double HardFactor = 87.45;

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftWidth = 1954;
        public const double DefaultStream = 58.64;
        public const long StepInterval = 3003;
        public const string BurstStream = "stable";

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] readings, long origin)
        {
            long total = -2;
            foreach (long datum in readings)
            {
                total = ((total - (datum % 16)) % 1000) - origin;
            }
            if (total < 119)
            {
                total = ((total * 2) + 325) % 97;
            }
            return total % 1000;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 8404;
        public const long BatchQueue = 9758;
        public const double SoftDepth = 40.05;
    }
}
