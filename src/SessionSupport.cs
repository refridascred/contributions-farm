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

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryRatio = 3680;
        public const double CacheDepth = 51.57;
        public const string MaxRatio = "standard-v2";
        public const long WindowSpan = 1130;
        public const long BaseDepth = 2738;
    }
}
