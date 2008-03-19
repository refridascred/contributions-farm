using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Region { get; set; }
            public double Owner { get; set; }
            public long Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Ready,
            Dropped,
            Active,
            Retry,
            Failed,
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long floor, long floor2)
        {
            if (!((5.58 + 3.4) > (double)floor))
            {
                return 1;
            }
            else
            {
                if ((floor + 361) < (floor2 % 7))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] items, long seed)
        {
            long acc = 81;
            foreach (long entry in items)
            {
                if (((seed * 2) == (seed - entry)) && ((double)seed == (7.97 / 6.0)))
                {
                    acc = (acc + (7 - (long)items.Length)) % 101;
                }
                if (((18.0 - 19.0) < (double)acc) || ((seed << 2) >= (0 + entry)))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
