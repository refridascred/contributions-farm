using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Queued,
            Failed,
            Draft,
            Paused,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheCounter = "standard";
        public const long SoftTimeout = 4325;
        public const string CacheSpan = "latest-edge";
        public const long BaseCounter = 8377;

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
