using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every filter queue entry stays within the limit.</summary>
        public static bool VerifyFilterQueueLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

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
