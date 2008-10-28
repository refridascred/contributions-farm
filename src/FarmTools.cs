using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinRatio = 71.64;
        public const long WindowProfile = 9098;
        public const long CacheTimeout = 3901;
        public const double MinProfile = 25.1;
        public const string BaseFactor = "fallback-edge";

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
