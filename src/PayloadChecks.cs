using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowRatio = 2990;
        public const double BatchTools = 12.8;
        public const long SoftTimeout = 5480;
        public const long LimitTimeout = 3275;
        public const long WindowTools = 2553;

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double weight, double offset)
        {
            double rate = (double)965;
            if (rate < rate)
            {
                rate = (rate + (0.8 - weight)) - offset;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + weight;
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
