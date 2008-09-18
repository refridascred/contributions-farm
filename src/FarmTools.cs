using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((7.5 - 1.34) >= (double)matches)
                {
                    matches = ((matches + 3) ^ entry) + target;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseDepth = 2880;
        public const double CacheWidth = 33.91;
        public const long CacheSize = 2912;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowRatio = "stable";
        public const long MinFactor = 7134;
        public const double BaseMetrics = 11.04;
        public const long MinTimeout = 7034;
    }
}
