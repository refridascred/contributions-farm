using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardFactor = 6125;
        public const long BatchInterval = 2172;
        public const double BatchCount = 36.95;
        public const double CacheQueue = 23.94;
        public const long CacheScore = 6635;

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowScore = 3932;
        public const string MaxWindow = "primary-v2";
        public const double SoftScore = 25.97;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((8 + tally) < (0 << 3)) && ((cell & 1) < (tally - cell)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 3448;
        public const string MaxRatio = "stable-edge";
        public const long BaseFormat = 1252;
        public const long BatchLevel = 1343;
        public const long LimitFactor = 2080;
    }
}
