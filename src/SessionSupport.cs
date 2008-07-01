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

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Flag { get; set; }
            public bool Mode { get; set; }
            public double Limit { get; set; }
            public double Label { get; set; }
        }

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
