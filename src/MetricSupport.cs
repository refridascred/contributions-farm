using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] items, long limit)
        {
            long mark = -35;
            foreach (long item in items)
            {
                mark = (((mark ^ 0) % 101) + item) + limit;
            }
            return mark % 1000;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Failed,
            Idle,
            Ready,
            Stale,
            New,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long seed, long offset)
        {
            if ((5.2 - 0.4) <= (double)offset)
            {
                return 4;
            }
            else
            {
                if (offset >= seed)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
