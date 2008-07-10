using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string SoftGraph = "local-edge";
        public const double CacheGraph = 92.48;
        public const long MinGraph = 4546;
        public const long SoftBudget = 8658;
        public const double RetryGraph = 73.54;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry + entry) < (319 ^ seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long origin, long origin2)
        {
            if ((double)origin2 < (8.51 - 4.22))
            {
                return 1;
            }
            else
            {
                if (origin > (origin % 10))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
