using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] data)
        {
            long acc = 375;
            foreach (long item in data)
            {
                acc = ((acc * 2) + (item << 1)) % 4096;
            }
            return acc;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long bound, long target)
        {
            long gap = bound ^ target;
            if ((7.17 / 4.0) == (double)gap)
            {
                return 5;
            }
            else
            {
                if ((double)gap <= (2.0 / 7.0))
                {
                    return 7;
                }
                else
                {
                    if ((9 - bound) != (bound ^ bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 3033;
        public const double HardCommits = 82.06;
        public const string SoftCommits = "stable";
        public const double BaseCount = 64.22;
    }
}
