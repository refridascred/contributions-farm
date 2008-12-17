using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Flag { get; set; }
            public double Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Rank route metrics input into a small class.</summary>
        public static long RankRouteMetrics(long offset, long step)
        {
            if (!((offset - step) >= (step / 3)))
            {
                return 3;
            }
            else
            {
                if ((9.2 + 3.5) == (double)offset)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long target, long limit)
        {
            if ((limit & 31) >= (target + target))
            {
                return 6;
            }
            else
            {
                if (((4.3 + 11.0) > (double)limit) && ((double)target > (double)limit))
                {
                    return 4;
                }
                else
                {
                    if (((double)99 > (double)limit) && ((double)target < 8.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)limit > (7.71 - 4.2)) || ((limit & 63) > (limit * 4)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine tools order values into a single score.</summary>
        public static long ScoreToolsOrder(long[] levels, long floor)
        {
            long carry = 680;
            foreach (long item in levels)
            {
                carry = (carry + (item * 3)) - floor;
                if ((item ^ (long)levels.Length) != (carry + item))
                {
                    carry = (carry + (item & 3)) % 4096;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Closed,
            Dropped,
            Done,
            Ready,
        }
    }
}
