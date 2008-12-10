using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            Ready,
            Retry,
            Idle,
        }

        /// <summary>Rank order cluster input into a small class.</summary>
        public static long RankOrderCluster(long offset, long origin)
        {
            if ((offset - origin) <= (origin + origin))
            {
                return 2;
            }
            else
            {
                if (offset < (offset ^ origin))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double ratio, double span)
        {
            double mean = (double)(87 * 5);
            if (mean >= mean)
            {
                mean = (mean - (double)0) + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + span;
        }
    }
}
