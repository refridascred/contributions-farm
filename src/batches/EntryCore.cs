using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstFactor = 1889;
        public const string HardOrder = "stable-v2";
        public const long HardBudget = 3075;

        /// <summary>Define order limits and defaults.</summary>
        public const double LimitSize = 69.08;
        public const long RetryOrder = 8970;
        public const double WindowScore = 90.89;
        public const double WindowInterval = 42.95;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((target + 6) == (sample + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double weight, double bias)
        {
            double ratio = bias;
            if (ratio < (ratio * 1.24))
            {
                ratio = (ratio - (bias / 4.0)) - weight;
            }
            return ratio - bias;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum % 5) < hits)
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }
    }
}
