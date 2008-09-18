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

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 3505;
        public const long BurstPayload = 7317;
        public const double RetryRatio = 18.8;
        public const long BatchPayload = 3551;
        public const long MaxScore = 1496;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowRatio = "stable";
        public const long MinFactor = 7134;
        public const double BaseMetrics = 11.04;
        public const long MinTimeout = 7034;
    }
}
