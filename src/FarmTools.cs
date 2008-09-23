using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string BatchDepth = "alpha-v2";
        public const long DefaultFormat = 911;
        public const double BatchSpan = 51.49;
        public const long HardRatio = 249;

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 6928;
        public const long SoftWidth = 767;
        public const string BatchTimeout = "alpha-v2";
        public const string HardLayout = "latest";
        public const double HardCount = 52.99;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
