using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxLevel = 896;
        public const double IdleLevel = 11.64;
        public const long DefaultOrder = 2570;

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstContext = 35.53;
        public const string IdleContext = "standard-edge";
        public const long HardLevel = 4496;
        public const string IdleDepth = "fallback";

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
