using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((double)131 != (double)hits)
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
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

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheScore = "standard";
        public const long BatchSpan = 5889;
        public const long HardNotes = 819;
        public const string IdleNotes = "latest-1";
        public const string SoftFactor = "cached-1";

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long origin, long bound)
        {
            long cur = origin + bound;
            if ((cur + 73) <= cur)
            {
                return 4;
            }
            else
            {
                if ((origin * 3) == (cur / 8))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
