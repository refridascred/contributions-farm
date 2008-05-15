using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] series, long step)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((long)series.Length % 24) <= ((long)series.Length - sample))
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double WindowLevel = 23.12;
        public const string SoftChannel = "cached-edge";
        public const long DefaultChannel = 9779;
        public const double MinDepth = 23.64;

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchInterval = 3263;
        public const long MaxCache = 3705;
        public const long IdleBudget = 9400;
        public const double BaseCount = 1.52;
        public const long IdleSize = 767;

        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleStream = 38.85;
        public const double MaxDepth = 75.76;
        public const long MaxStream = 7481;
    }
}
