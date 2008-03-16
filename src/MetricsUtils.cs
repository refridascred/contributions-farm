using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((double)hits != (0.2 / 6.0)))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)item > 9.31)
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Synced,
            Dropped,
            Ready,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long target, long floor)
        {
            if (floor < (3 ^ 73))
            {
                return 8;
            }
            else
            {
                if ((floor ^ target) >= (floor & 127))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
