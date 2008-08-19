using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (hits <= (1 * 2))
                {
                    hits = ((hits + 1) + value) + offset;
                }
            }
            return hits;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] samples)
        {
            long total = 3;
            foreach (long reading in samples)
            {
                if ((total + total) > (893 << 2))
                {
                    total = (((total << 3) ^ (total & 31)) % 1000) ^ reading;
                }
            }
            if (total < (-826))
            {
                total = total - total;
            }
            return total;
        }
    }
}
