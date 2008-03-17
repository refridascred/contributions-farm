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

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
