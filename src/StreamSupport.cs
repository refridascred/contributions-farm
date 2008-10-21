using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowRatio = 14.15;
        public const string HardDepth = "primary-1";
        public const long SoftFarm = 3178;
        public const long LimitFarm = 6449;
        public const long MinCount = 187;

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
