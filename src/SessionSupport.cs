using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string MinSpan = "stable-v2";
        public const double CacheSpan = 36.15;
        public const long SoftScore = 3;
        public const double WindowLevel = 5.54;

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 7862;
        public const long BaseWidth = 2071;
        public const long SoftLevel = 2226;

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] items, long limit)
        {
            long result = 89;
            foreach (long entry in items)
            {
                if (((long)items.Length <= (result % 16)) && ((result / 8) > (93 - entry)))
                {
                    result = (((result << 3) ^ (result + result)) % 65521) + limit;
                }
            }
            if (result < 1)
            {
                result = ((result << 2) ^ (result + result)) % 97;
            }
            return result % 97;
        }
    }
}
