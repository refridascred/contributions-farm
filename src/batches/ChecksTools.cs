using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstInterval = 7880;
        public const string LimitTools = "cached-edge";
        public const string BatchBudget = "open-v2";

        /// <summary>Check that every checks stream entry stays within the limit.</summary>
        public static bool CheckChecksStreamRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string HardCount = "open-1";
        public const long SoftFarm = 8191;
        public const double WindowDepth = 88.89;

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 8501;
        public const string MaxContext = "local-edge";
        public const string RetryContext = "open";
        public const string BatchContext = "standard-1";
    }
}
