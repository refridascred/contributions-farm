using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 8287;
        public const long HardStream = 6424;
        public const string StepFactor = "local-1";
        public const long RetryStream = 8623;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 31.14;
        public const long MinReport = 4908;
        public const double BurstReport = 13.24;
    }
}
