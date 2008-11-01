using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheBudget = 6870;
        public const long BaseSpan = 8351;
        public const double IdleFactor = 81.04;
        public const long SoftPayload = 1333;
        public const string CachePayload = "cached-1";

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] series)
        {
            long anchor = 36;
            foreach (long value in series)
            {
                anchor = ((anchor << 3) ^ (anchor ^ value)) % 4096;
            }
            if (anchor > (-7))
            {
                anchor = (anchor + (anchor + anchor)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 6310;
        public const double BaseBudget = 81.67;
        public const long WindowScore = 3523;
        public const long MaxGraph = 5120;
        public const long RetryGraph = 8595;
    }
}
