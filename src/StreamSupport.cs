using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Dropped,
            Retry,
            Draft,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string IdleRoute = "open-v2";
        public const double HardRoute = 18.04;
        public const long BaseSize = 8842;
        public const long MinWidth = 8702;

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((long)series.Length != (cell >> 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
