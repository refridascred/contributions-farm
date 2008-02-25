using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 < (double)408)
            {
                gain2 = (gain2 + (double)55) - gain;
            }
            return gain2 - (double)940;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count - sample) == (421 / 5))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }
    }
}
