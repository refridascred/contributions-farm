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

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftWidth = 263;
        public const double MinInterval = 29.03;
        public const string BatchWidth = "legacy-edge";

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepDepth = 9666;
        public const long WindowContributi = 7997;
        public const long WindowScore = 1899;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((floor - reading) < floor)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
