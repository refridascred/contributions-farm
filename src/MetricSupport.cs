using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)matches > 0.6)
                {
                    matches = ((matches + 2) ^ value) + target;
                }
            }
            return matches;
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
