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

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Token { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
            public bool Score { get; set; }
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
