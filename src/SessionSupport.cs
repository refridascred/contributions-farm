using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 2242;
        public const long WindowInterval = 9057;
        public const long MaxFactor = 5206;

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 5198;
        public const long CacheTimeout = 4475;
        public const string HardDepth = "open-edge";

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
