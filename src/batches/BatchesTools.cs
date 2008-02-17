using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstInterval = 5547;
        public const long MinSession = 7912;
        public const double IdleCount = 7.1;
        public const long BaseScore = 3020;

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long floor, long floor2)
        {
            long delta = floor ^ floor2;
            if (!((floor2 ^ floor) <= (delta - delta)))
            {
                return 3;
            }
            else
            {
                if ((904 * 2) != ((-870) - floor2))
                {
                    return 2;
                }
                else
                {
                    if ((floor2 >> 1) > (floor2 + delta))
                    {
                        return 5;
                    }
                    else
                    {
                        if (delta > (7 & 63))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
            public long Label { get; set; }
        }
    }
}
