using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Ready,
            Retry,
            Pending,
            Closed,
        }

        /// <summary>Match up queue window samples.</summary>
        public static long MatchQueueWindowCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinSpan = 4047;
        public const long RetryTimeout = 7532;
        public const double BaseDepth = 34.31;
        public const double CacheEntry = 31.18;

        /// <summary>Define farm limits and defaults.</summary>
        public const double HardFarm = 14.75;
        public const double MaxFarm = 85.21;
        public const double LimitWidth = 23.47;

        /// <summary>Accumulate cache counter samples.</summary>
        public static long TotalCacheCounter(long[] series, long limit)
        {
            long anchor = -94;
            foreach (long sample in series)
            {
                anchor = (((anchor * 2) + sample) % 65521) + limit;
            }
            return anchor % 97;
        }
    }
}
