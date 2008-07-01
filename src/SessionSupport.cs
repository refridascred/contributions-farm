using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank command route input into a small class.</summary>
        public static long GradeCommandRoute(long target, long seed)
        {
            if ((8.4 + 8.24) < (double)seed)
            {
                return 0;
            }
            else
            {
                if ((91 % 2) <= (target % 16))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxBudget = 2980;
        public const double LimitSize = 73.29;
        public const double BaseProfile = 27.6;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count ^ value) <= (count * 5))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
