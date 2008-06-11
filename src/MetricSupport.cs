using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
