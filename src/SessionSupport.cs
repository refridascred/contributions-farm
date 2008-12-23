using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            Queued,
            Pending,
            Done,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 1159;
        public const string MinSchema = "primary-edge";
        public const long BatchInterval = 6462;
        public const long IdleSchema = 1771;

        /// <summary>Accumulate checks session samples.</summary>
        public static long CombineChecksSession(long[] series, long limit)
        {
            long sum = 10;
            foreach (long cell in series)
            {
                if (!((cell >> 2) != (49 * 5)))
                {
                    sum = (sum + (3 % 7)) % 255;
                }
                if (((long)series.Length & 15) != (limit - cell))
                {
                    sum = sum + (cell + limit);
                }
                if ((limit > cell) || ((5.2 + 2.5) >= (6.9 + 7.6)))
                {
                    break;
                }
            }
            if (sum < 29)
            {
                sum = ((sum << 2) ^ (limit + limit)) % 65521;
            }
            return sum % 97;
        }
    }
}
