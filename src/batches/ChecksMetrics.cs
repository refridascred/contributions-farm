using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Dropped,
            Paused,
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Pending,
            Queued,
            Failed,
            Idle,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 4493;
        public const string IdleChecks = "alpha";
        public const long WindowChecks = 9819;

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double bias, double offset)
        {
            double ratio = 20.0 / 5.0;
            if (ratio > (6.3 * 14.0))
            {
                ratio = (ratio - (ratio * 13.0)) - bias;
            }
            else
            {
                ratio = ratio - (double)86;
            }
            return ratio - offset;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheScore = "standard";
        public const long BatchSpan = 5889;
        public const long HardNotes = 819;
        public const string IdleNotes = "latest-1";
        public const string SoftFactor = "cached-1";

        /// <summary>Adjust a window cache reading.</summary>
        public static double ProjectWindowCache(double scale, double offset)
        {
            double weight = scale;
            if (weight >= 0.7)
            {
                weight = (weight - scale) - offset;
            }
            return weight + weight;
        }
    }
}
