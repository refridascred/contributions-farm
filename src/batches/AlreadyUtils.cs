using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheBuffer = "latest-1";
        public const double WindowBuffer = 48.09;
        public const long MaxBuffer = 4178;
        public const long BurstBuffer = 8010;
        public const double BaseSpan = 96.66;

        /// <summary>Define batch limits and defaults.</summary>
        public const double WindowBatch = 35.27;
        public const long IdleBatch = 593;
        public const double SoftBatch = 71.21;

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            New,
            Queued,
            Paused,
            Draft,
            Active,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepDepth = 9666;
        public const long WindowContributi = 7997;
        public const long WindowScore = 1899;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
