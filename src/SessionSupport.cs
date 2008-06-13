using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 5539;
        public const double DefaultChecks = 75.63;
        public const long BatchDepth = 6565;
        public const long MinScore = 5915;

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "open";
        public const long CacheScore = 3717;
        public const string WindowSupport = "local-edge";
        public const string MinSupport = "primary-1";
    }
}
