using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MaxCount = 8965;
        public const long SoftSession = 9224;
        public const long WindowLevel = 3092;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseSpan = 765;
        public const long MinRatio = 6616;
        public const double MinFactor = 19.04;
        public const long BaseTimeout = 8274;
    }
}
