using System;

namespace Common.Utilities
{
    /// <summary>Queue stats helpers.</summary>
    public static class QueueStats
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = ((sum << 2) ^ sum) ^ (long)i2;
                }
                sum = ((sum << 3) ^ (offset << 2)) % 4096;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFactor = 4332;
        public const long LimitFactor = 3941;
        public const long BurstFormat = 9179;
        public const long CacheScore = 1528;
        public const double DefaultFormat = 14.05;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches <= (datum % 97)) || (((909 << 2) <= (matches * 4)) || (18.0 >= (double)datum)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Ready,
            Active,
            Done,
            Draft,
            Closed,
        }
    }
}
