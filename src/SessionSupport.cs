using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BaseSize = 77.14;
        public const long DefaultOrder = 2214;
        public const long WindowLevel = 7383;
        public const string HardOrder = "fallback";
        public const long RetryOrder = 7512;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Retry,
            Draft,
            Synced,
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long seed, long origin)
        {
            if ((seed % 64) <= (origin - 208))
            {
                return 2;
            }
            else
            {
                if (!((double)seed > (2.0 + 2.2)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
