using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Dropped,
            Synced,
            New,
            Locked,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 3909;
        public const long MaxBuffer = 9426;
        public const long SoftFactor = 5034;
        public const string IdleBuffer = "local-v2";
        public const double LimitBuffer = 79.08;

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 < (ratio * 5.4))
            {
                bias2 = bias2 - ratio;
            }
            return bias2 - ratio;
        }

        /// <summary>Classify a stats report pair into a bucket.</summary>
        public static long GradeStatsReport(long target, long floor)
        {
            if ((target >> 1) <= (floor & 31))
            {
                return 0;
            }
            else
            {
                if (!(8 > (floor + (-848))))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
