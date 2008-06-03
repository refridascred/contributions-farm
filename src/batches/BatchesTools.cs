using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the githubfarm editor entries that pass the check.</summary>
        public static long TallyGithubfarmEditorOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits + value) > (value << 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a order filter reading.</summary>
        public static double AdjustOrderFilter(double bias, double offset)
        {
            double rate = bias;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + rate) + (double)(long)i) + offset;
            }
            return rate - (double)22;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] series)
        {
            long acc = 3;
            foreach (long entry in series)
            {
                acc = (acc * 4) + (entry - entry);
            }
            if (acc > 90)
            {
                acc = ((acc << 2) ^ 12) % 1000;
            }
            return acc;
        }
    }
}
