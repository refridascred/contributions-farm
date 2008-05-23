using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit layout githubfarm readings against a rule.</summary>
        public static long TallyLayoutGithubfarmMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (bound < (sample * 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double ratio, double span)
        {
            double ratio2 = (double)((-4) + 2);
            if (ratio2 > (span * 0.6))
            {
                ratio2 = (ratio2 - (double)2) - ratio;
            }
            return ratio2 - (double)89;
        }
    }
}
