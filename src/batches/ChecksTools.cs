using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BaseReport = "open-1";
        public const long SoftReport = 3156;
        public const long MaxScore = 7571;
        public const double MinReport = 66.19;
        public const double StepBudget = 64.99;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits >> 5) < (194 % 5))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 4299;
        public const double LimitInterval = 6.02;
        public const long BatchCommand = 2384;
        public const long SoftTimeout = 2871;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen << 2) >= cell)
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }
    }
}
