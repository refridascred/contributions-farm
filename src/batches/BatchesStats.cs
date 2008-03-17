using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample ^ 8) > 301)
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Classify a schema support pair into a bucket.</summary>
        public static long GradeSchemaSupport(long seed, long target)
        {
            long diff = seed ^ target;
            if ((diff / 9) >= (seed - seed))
            {
                return 4;
            }
            else
            {
                if ((diff - target) >= (seed + target))
                {
                    return 5;
                }
                else
                {
                    if ((target + seed) >= 515)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Owner { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Count the batches window entries that pass the check.</summary>
        public static long AuditBatchesWindowGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample * 5) >= (bound & 31))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
