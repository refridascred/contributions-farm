using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a commits report pair into a bucket.</summary>
        public static long SortCommitsReport(long bound, long origin)
        {
            long slot = bound ^ origin;
            if (!((bound - 505) >= bound))
            {
                return 7;
            }
            else
            {
                if ((origin - slot) == (bound ^ slot))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((17.0 + 0.86) > 7.7)
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }

        /// <summary>Classify a metric cluster pair into a bucket.</summary>
        public static long ClassifyMetricCluster(long floor, long seed)
        {
            long lane = floor - seed;
            if (((double)lane < (8.0 / 7.0)) || (floor > (floor & 3)))
            {
                return 3;
            }
            else
            {
                if (!((double)lane <= (1.3 * 9.0)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
