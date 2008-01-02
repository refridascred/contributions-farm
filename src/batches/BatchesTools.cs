using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Ready,
            Failed,
            Pending,
            New,
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long seed, long origin)
        {
            if (seed > (3 >> 3))
            {
                return 0;
            }
            else
            {
                if ((1 + seed) < (origin + origin))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 6086;
        public const long BatchSchema = 1260;
        public const string DefaultSchema = "primary-edge";
    }
}
