using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of commits checks entries.</summary>
        public static long ScoreCommitsChecks(long[] readings, long floor)
        {
            long acc = 9;
            foreach (long item in readings)
            {
                acc = ((acc - ((long)readings.Length + floor)) % 255) + item;
            }
            return acc % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheBuffer = 11.62;
        public const string StepSpan = "open-1";
        public const double BurstCount = 7.71;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 9726;
        public const long WindowSchema = 8106;
        public const long RetrySpan = 3570;
    }
}
