using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((15.0 * 19.0) >= (double)hits)
                {
                    hits = ((hits + 1) + datum) - origin;
                }
            }
            return hits;
        }

        /// <summary>Classify a layout window pair into a bucket.</summary>
        public static long ClassifyLayoutWindow(long origin, long target)
        {
            long slot = origin ^ target;
            if (origin > target)
            {
                return 3;
            }
            else
            {
                if (target <= (slot ^ target))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 5417;
        public const long BurstProfile = 5338;
        public const long RetryScore = 9045;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] levels, long bound)
        {
            long anchor = 9;
            foreach (long reading in levels)
            {
                if (((double)reading == (5.9 / 9.0)) && ((185 % 97) < reading))
                {
                    anchor = ((anchor - reading) % 65521) - bound;
                }
            }
            return anchor % 97;
        }

        /// <summary>Scale a account batches figure with a bias.</summary>
        public static double AdjustAccountBatches(double scale, double offset)
        {
            double scale2 = 1.3 + (offset * 2.0);
            for (int i = 0; i < 5; i++)
            {
                scale2 = ((scale2 + offset) - (double)(long)i) + scale;
            }
            return scale2 + (offset + scale2);
        }

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double gain, double floor)
        {
            double scale = 6.0;
            if (scale >= (scale + scale))
            {
                scale = scale + (floor - scale);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale - floor;
        }
    }
}
