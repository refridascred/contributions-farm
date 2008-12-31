using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftFactor = 6844;
        public const long SoftSupport = 4923;
        public const long BaseDepth = 5212;

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCache = 71.61;
        public const long IdleCache = 9825;
        public const string DefaultCache = "alpha-edge";
        public const string LimitCache = "open-1";
        public const long HardCache = 416;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
