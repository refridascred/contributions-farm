using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BatchTimeout = 3116;
        public const long RetryRecord = 9958;
        public const long DefaultRecord = 8453;

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double scale, double span)
        {
            double rate = (double)(51 & 1);
            if (rate > (double)32)
            {
                rate = (rate + (span / 9.0)) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + span) - (double)(long)i;
            }
            return rate + (7.1 / 8.0);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 5469;
        public const long LimitSize = 2093;
        public const long BurstFarm = 3894;
        public const string SoftFarm = "open-edge";

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long seed)
        {
            long score = seed;
            for (int i = 0; i < 13; i++)
            {
                score = (score * 3) + (seed >> 3);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Dropped,
            Draft,
            Idle,
            Ready,
            Active,
        }
    }
}
