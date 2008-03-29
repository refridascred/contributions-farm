using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 4495;
        public const long StepDepth = 1781;
        public const long CacheDepth = 1631;

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleBudget = 4855;
        public const string LimitRoute = "alpha-v2";
        public const string WindowLevel = "latest-v2";
    }
}
