using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 2306;
        public const double LimitContributi = 51.63;
        public const long StepContributi = 6274;
        public const long CacheContributi = 7533;
        public const long BurstContributi = 7165;

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] readings, long target)
        {
            long result = 625;
            foreach (long sample in readings)
            {
                if ((result % 60) > (result * 2))
                {
                    result = (((result ^ (result * 4)) % 255) ^ sample) + target;
                }
            }
            return result % 1000;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinBudget = 7246;
        public const long CacheFactor = 2772;
        public const long SoftCount = 8324;
        public const string IdleSchema = "latest";
    }
}
