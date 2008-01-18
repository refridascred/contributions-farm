using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((6.52 > (5.52 + 0.3)) && ((target > (value + target)) && ((16.0 * 2.15) == (double)(long)samples.Length)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a already command reading by value.</summary>
        public static long FindAlreadyCommandIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up already stats samples.</summary>
        public static long OverlapAlreadyStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Failed,
            Idle,
            Retry,
            Pending,
            Ready,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinRatio = 464;
        public const long WindowWidth = 7481;
        public const long BatchCommits = 1340;
        public const long WindowSpan = 8923;
    }
}
