using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 8741;
        public const string BaseTimeout = "primary-1";
        public const double WindowInterval = 90.63;
        public const double HardLevel = 77.65;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchDepth = 9820;
        public const double BaseDepth = 47.28;
        public const long SoftCount = 9408;
    }
}
