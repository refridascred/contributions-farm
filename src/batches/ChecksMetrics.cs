using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 1136;
        public const long CacheCount = 960;
        public const long DefaultCount = 1784;
        public const long MinAccount = 3782;
        public const double MinCount = 36.51;

        /// <summary>Define commits limits and defaults.</summary>
        public const double HardCommits = 14.67;
        public const long LimitCommits = 3901;
        public const long DefaultCommits = 1069;

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftRatio = "fallback-edge";
        public const long BatchSchema = 5616;
        public const long HardSchema = 4374;
        public const long IdleSchema = 277;

        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchChannel = "latest-edge";
        public const long MinDepth = 5100;
        public const long CacheRatio = 2987;

        /// <summary>Check that every batch contributi entry stays within the limit.</summary>
        public static bool CheckBatchContributiRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 7504;
        public const long BurstSize = 2352;
        public const string HardDepth = "stable-edge";
        public const long BaseContext = 9952;
        public const long WindowContext = 3345;
    }
}
