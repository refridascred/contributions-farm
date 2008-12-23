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

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

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
