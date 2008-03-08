using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchNotes = "latest-edge";
        public const long CacheScore = 4729;
        public const double BaseLevel = 5.31;
        public const long CacheNotes = 4665;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long step, long target)
        {
            if ((step - target) <= target)
            {
                return 0;
            }
            else
            {
                if ((target + step) < step)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((6.4 / 2.0) >= (double)cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long origin, long target)
        {
            long edge = origin ^ target;
            if (edge < (edge + origin))
            {
                return 6;
            }
            else
            {
                if ((edge >> 2) <= target)
                {
                    return 1;
                }
                else
                {
                    if ((edge >> 1) < (origin + target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
