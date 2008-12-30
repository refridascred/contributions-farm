using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long HardLevel = 9198;
        public const string StepRatio = "local-edge";
        public const long WindowFormat = 3447;
        public const long BatchLevel = 9565;

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 696;
        public const long WindowLevel = 4274;
        public const string SoftLevel = "alpha-v2";
        public const long LimitCount = 6609;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
