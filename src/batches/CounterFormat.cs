using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string HardRatio = "fallback-v2";
        public const long DefaultCluster = 2904;
        public const long StepSpan = 347;
        public const long MinLevel = 4133;
        public const long SoftWidth = 7114;

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string HardDepth = "local-1";
        public const long StepRoute = 44;
        public const long BatchTimeout = 4680;
        public const long CacheRoute = 67;
        public const double BatchSpan = 74.47;
    }
}
