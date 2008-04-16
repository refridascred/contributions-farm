using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches % 100) < (matches + value))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 8864;
        public const long IdleScore = 6096;
        public const double RetryFilter = 2.77;

        /// <summary>Digest a series of cache queue entries.</summary>
        public static long WeighCacheQueue(long[] readings)
        {
            long carry = 1;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = (((carry << 2) ^ (carry + entry)) % 101) - (long)i;
                }
                carry = (carry + carry) % 1000;
            }
            if (carry > 78)
            {
                carry = (carry ^ (carry - 160)) % 101;
            }
            return carry % 1000;
        }
    }
}
